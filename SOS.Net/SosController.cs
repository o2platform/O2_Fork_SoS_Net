using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using SOS.Net.Core;
using SOS.Net.Core.Cdb;
using SOS.Net.Core.Cdb.Commands;

namespace SOS.Net
{
    /// <summary>
    /// http://geekswithblogs.net/.netonmymind/archive/2006/03/14/72262.aspx
    /// </summary>
    public class SosController : IDisposable
    {
        private ListViewItem[] processes;

        /// <summary>
        /// don't use me, use SosController.types instead
        /// </summary>
        private ListViewItem[] _types;

        private ListViewItem[] types
        {
            get { return _types ?? new ListViewItem[] { }; }
            set { _types = value; }
        }

        private CdbProcess cdb;

        private CdbSettings settings;

        private bool cdbStarted;

        public event EventHandler<CdbEventArgs> OnCdbOuput;

        public bool Attached
        {
            get { return this.cdb != null; }
        }

        public CdbSettings LoadSettings()
        {
            Settings.Default.Reload();

            this.settings = new CdbSettings();
            this.settings.CdbPath = Settings.Default.CdbPath;
            this.settings.SosexPath = Settings.Default.SosexPath;            

            return this.settings;
        }

        public void SaveSettings(CdbSettings settings)
        {
            this.settings = settings;
            Settings.Default.CdbPath = settings.CdbPath;
            Settings.Default.SosexPath = settings.SosexPath;
            Settings.Default.Save();
            this.LoadSettings();
        }

        public ListViewItem[] RefreshProcesses()
        {
            List<ListViewItem> result = new List<ListViewItem>();

            List<string> dotnetProcesses = new List<string>();

            /*ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_PerfFormattedData_NETFramework_NETCLRLoading");
            foreach (ManagementObject item in searcher.Get())
            {
                string name = item.Properties["Name"].Value.ToString();
                if (!name.Equals("_Global_"))
                {
                    // remove the number
                    name = Regex.Match(name, "([^#]*)#?[0-9]*").Groups[1].Value;

                    // add .exe
                    name += ".exe";

                    dotnetProcesses.Add(name);
                }
            }*/

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process");
            foreach (ManagementObject item in searcher.Get())
            {
                string name = item.Properties["Name"].Value.ToSafeString();
                bool isDotNet = dotnetProcesses.Where(a => a.Equals(name)).Any();

                result.Add(new ListViewItem(new string[]
                {
                  item.Properties["ProcessId"].Value.ToSafeString(),
                  item.Properties["Name"].Value.ToSafeString(),
                  item.Properties["ExecutablePath"].Value.ToSafeString(),
                  item.Properties["CommandLine"].Value.ToSafeString(),
                  isDotNet.ToString()
                }));
            }

            processes = result.OrderBy(item => item.SubItems[4].Text).ToArray();
            return processes;
        }

        public ListViewItem[] FilterProcesses(string filter)
        {
            if (processes == null)
                return new ListViewItem[0];
            return processes.Where(p => p.SubItems[1].Text.IndexOf(filter, StringComparison.OrdinalIgnoreCase) != -1).ToArray();
        }

        public void AttachToProcess(string pid)
        {
            this.cdb = CdbProcess.Attach(this.settings, int.Parse(pid));
            this.cdb.OnCdbOuput += new EventHandler<CdbEventArgs>(cdb_OnCdbOuput);
        }

        public void OpenDump(string path)
        {
            if (this.cdb == null)
            {
                this.cdb = CdbProcess.Attach(this.settings, path);
                this.cdb.OnCdbOuput += new EventHandler<CdbEventArgs>(cdb_OnCdbOuput);
            }
            else
            {
                this.cdb.LoadDump(path);
            }
        }

        public void SaveDump(string path)
        {
            if(File.Exists(path))
                File.Delete(path);
            this.cdb.ExecuteCommand(string.Format(".dump /mfh \"{0}\"", path.Replace("\\", "\\\\")));
        }

        protected void cdb_OnCdbOuput(object sender, CdbEventArgs e)
        {
            if (OnCdbOuput != null)
                OnCdbOuput(this, e);
        }

        public string GetPreviousCommand()
        {
            return cdb.GetPreviousCommand();
        }

        public string GetNextCommand()
        {
            return cdb.GetNextCommand();
        }

        public string ExecuteCommand(string command)
        {
            return cdb.ExecuteCommand(command);
        }

        public void Detach()
        {
            if (cdb != null)
            {
                cdb.Dispose();
                cdb = null;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.Detach();
        }

        #endregion

        public ListViewItem[] GetAllAppDomains()
        {
            return this.cdb.GetAppDomains()
                .Select(a => a.Value)
                .Select(a => new ListViewItem(new string[]
                {
                    a.Address, 
                    a.Name
                })).ToArray();
        }

        public ListViewItem[] GetAssemblies(string appDomainAddress)
        {

            return this.cdb.ExecuteCommand(new AssemblyInfoCommand(appDomainAddress))
                .Select(a => new ListViewItem(new string[]
                {
                    a.Address, 
                    a.Name
                })).ToArray();
        }

        public ListViewItem[] GetAssemblies()
        {
            return this.cdb.ExecuteCommand(new AssemblyInfoCommand())
                .Select(a => new ListViewItem(new string[]
                {
                    a.Address, 
                    a.Name
                })).ToArray();
        }

        public ListViewItem[] GetDumpHeapTypes()
        {
            this.types = this.cdb.GetTypes()
                .Select(a => a.Value)
                .Select(a => new ListViewItem(new string[]
                {
                    a.Address, 
                    a.Count,
                    a.TotalSize,
                    a.ClassName
                })).ToArray();

            return this.types;
        }

        public ListViewItem[] GetInstances(string typeAddress)
        {
            return this.cdb.ExecuteCommand(new InstanceInfoCommand(typeAddress))
                .Select(a => a.Value)
                .Select(a => new ListViewItem(new string[]
                {
                    a.Address, 
                    a.Size
                })).ToArray();
        }

        public ListViewItem[] GetInstanceDump(string instanceAddress)
        {
            return this.cdb.ExecuteCommand(new InstanceFieldInfoCommand(instanceAddress))
                .Select(a => a.Value)
                .Select(a => new ListViewItem(new string[]
                {
                    a.FieldAddress, 
                    a.TypeName,                                                                                
                    a.Attribut,
                    a.Value,
                    a.FieldName,
                })).ToArray();
        }

        public ListViewItem[] GetInstanceDump(string instanceAddress, string index)
        {
            return this.cdb.ExecuteCommand(new InstanceFieldInfoCommand(instanceAddress, int.Parse(index)))
               .Select(a => a.Value)
               .Select(a => new ListViewItem(new string[]
                {
                    a.FieldAddress, 
                    a.TypeName,                                                                                
                    a.Attribut,
                    a.Value,
                    a.FieldName,
                })).ToArray();
        }

        public ListViewItem[] FilterTypes(string typeName)
        {
            Func<ListViewItem, bool> filteringPredicate =
                (item) =>
                item.SubItems[3].Text.IndexOf(typeName, StringComparison.OrdinalIgnoreCase) != -1;
            return this.types.Where(filteringPredicate).ToArray();
        }

        public InstanceInfoDetails GetInstanceDumpDetails(string instanceAddress)
        {
            return this.cdb.ExecuteCommand(new InstanceInfoDetailsCommand(instanceAddress)).First().Value;
        }

        public InstanceInfoDetails GetInstanceDumpDetails(string address, string index)
        {
            return this.cdb.ExecuteCommand(new InstanceInfoDetailsCommand(address, int.Parse(index))).First().Value;
        }

        public ListViewItem[] GetArrayInstances(string selectedAddress)
        {
            return this.cdb.ExecuteCommand(new ArrayInstanceInfoCommand(selectedAddress))
                .Select(a => a.Value)
                .Select(a => new ListViewItem(new string[]
                {
                    a.Number, 
                    a.Address
                })).ToArray();

        }

        public ListViewItem[] GetInstanceRef(string selectedAddress)
        {
            return this.cdb.ExecuteCommand(new ReferenceInfoCommand(selectedAddress))
                .Select(a => a.Value)
                .Select(a => new ListViewItem(new string[]
                {
                    a.Address,
                    a.Name
                })).ToArray();
        }
    }

    internal static class StringExtensions
    {
        public static string ToSafeString(this object obj)
        {
            return obj == null ? string.Empty : obj.ToString();
        }
    }
}
