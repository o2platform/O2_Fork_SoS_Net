using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SOS.Net.Core.Cdb
{
    public class CdbProcess : IDisposable
    {
        private Process cdb;

        private readonly CdbSettings settings;

        private readonly List<string> commandHistory = new List<string>();
        
        private int commandHistoryPosition;

        public event EventHandler<CdbEventArgs> OnCdbOuput;

        /// <summary>
        /// Create a new CdbProcess and attach it to a process
        /// </summary>
        /// <param name="settings">settings to find CDB command line, etc.</param>
        /// <param name="pid">pid of the process to attach</param>
        /// <returns>The CdbProcess attached</returns>
        public static CdbProcess Attach(CdbSettings settings, int pid)
        {
            return new CdbProcess(settings, pid);
        }

        /// <summary>
        /// Create a new CdbProcess and open the dump file
        /// </summary>
        /// <param name="settings">settings to find CDB command line, etc.</param>
        /// <param name="path">path to the dump file</param>
        /// <returns>The CdbProcess attached</returns>
        public static CdbProcess Attach(CdbSettings settings, string path)
        {
            return new CdbProcess(settings, path);
        }

        protected CdbProcess(CdbSettings settings, string path)
        {
            this.settings = settings;

            var pinfo = new ProcessStartInfo
            {
                FileName = Path.Combine(this.settings.CdbPath, "cdb.exe"),
                WorkingDirectory = ".",
                Arguments = string.Format("-z \"{0}\"", path),
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };

            cdb = Process.Start(pinfo);

            this.Start();
        }

        public void LoadDump(string path)
        {
            this.ExecuteCommand(string.Format(".opendump \"{0}\"", path.Replace("\\", "\\\\")));
        }       

        protected CdbProcess(CdbSettings settings, int pid)
        {
            this.settings = settings;

            var pinfo = new ProcessStartInfo
            {
                FileName = Path.Combine(this.settings.CdbPath, "cdb.exe"),
                WorkingDirectory = ".",
                Arguments = string.Format("-p {0}", pid),
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };

            cdb = Process.Start(pinfo);

            this.Start();
        }

        private CdbProcess Start()
        {
            this.ExecuteCommand(".loadby sos mscorwks");

            string sosexFullPath = this.settings.SosexPath;
            if (string.IsNullOrEmpty(sosexFullPath))
                sosexFullPath = AppDomain.CurrentDomain.BaseDirectory;
            sosexFullPath = Path.Combine(sosexFullPath, "sosex.dll");
            if (File.Exists(sosexFullPath))
            {
                sosexFullPath = sosexFullPath.Replace("\\", "\\\\");
                this.ExecuteCommand(string.Format(".load \"{0}\"", sosexFullPath));
            }

            return this;
        }

        public IEnumerable<T> ExecuteCommand<T>(ICdbCommand<T> command)
        {
            return command.Result(this);
        }

        public string ExecuteCommand(string command)
        {
            commandHistory.Add(command);
            commandHistoryPosition = commandHistory.Count - 1;

            cdb.StandardInput.WriteLine(command);
            var endToken = Guid.NewGuid().ToString();
            cdb.StandardInput.WriteLine(".echo " + endToken);	//Tagging the end of the output

            var output = new StringBuilder();
            string line = null;
            do
            {
                line = cdb.StandardOutput.ReadLine();
                if (line != null)
                {
                    line = line.Replace("\n", Environment.NewLine);
                    output.AppendLine(line);
                }
            } while (line != null && !line.EndsWith(endToken));
            if (OnCdbOuput != null)
                OnCdbOuput(this, new CdbEventArgs(command, output.ToString()));

            return output.ToString();
        }

        public string GetPreviousCommand()
        {
            commandHistoryPosition--;
            if (commandHistoryPosition < 0)
                commandHistoryPosition = 0;
            return this.commandHistory[commandHistoryPosition];
        }

        public string GetNextCommand()
        {
            commandHistoryPosition++;
            if (commandHistoryPosition >= commandHistory.Count)
                commandHistoryPosition = commandHistory.Count-1;
            return this.commandHistory[commandHistoryPosition];
        }

        protected void Detach()
        {
            if (cdb != null)
            {
                this.ExecuteCommand(".detach");
                cdb.StandardInput.WriteLine(".q");
                cdb.StandardOutput.ReadToEnd();
                //this.cdb.Kill();
                this.cdb.Dispose();
                this.cdb = null;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.Detach();
        }       

        #endregion
    }
}
