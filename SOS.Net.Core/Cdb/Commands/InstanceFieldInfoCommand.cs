using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SOS.Net.Core.Cdb.Commands
{
    public class InstanceFieldInfoCommand : ICdbCommand<CdbQueryable<InstanceFieldInfo>>
    {
        private string instanceAddress;

        private int? index;

        public InstanceFieldInfoCommand(string instanceAddress)
        {
            this.instanceAddress = instanceAddress;
            this.index = 0;
        }

        public InstanceFieldInfoCommand(string instanceAddress, int index)
        {
            this.instanceAddress = instanceAddress;
            this.index = index;
        }

        #region ICdbCommand<CdbQueryable<InstanceFieldInfo>> Members

        public IEnumerable<CdbQueryable<InstanceFieldInfo>> Result(CdbProcess process)
        {
            // TODO refactoring to avoid copy/paste between DumpObject and DumpArray
            if (index != null)
                return this.DumpObject(process);
            else
                return this.DumpArray(process);            
        }

        private IEnumerable<CdbQueryable<InstanceFieldInfo>> DumpArray(CdbProcess process)
        {
            var output = process.ExecuteCommand(string.Format("!DumpArray -details {0}", this.instanceAddress));
            StringReader reader = new StringReader(output);

            List<CdbQueryable<InstanceFieldInfo>> result = new List<CdbQueryable<InstanceFieldInfo>>();

            string line = reader.ReadLine();
            while (line != null)
            {
                while (line != null && !line.StartsWith("Element Methodtable"))
                    line = reader.ReadLine();

                while (line != null && !Regex.IsMatch(line, string.Format("\\[{0}\\].*", index)))
                    line = reader.ReadLine();

                while (line != null && !Regex.IsMatch(line, ".*Fields:"))
                    line = reader.ReadLine();

                if (line == null)
                    continue;

                // skip the header of the array
                line = reader.ReadLine();

                // and read the next line
                line = reader.ReadLine();

                while (line != null)
                {
                    if (Regex.Match(line, " *>> Domain:Value.*").Success)
                    {
                        line = reader.ReadLine();
                        continue;
                    }

                    if (Regex.Match(line, "0:005>.*").Success)
                    {
                        line = reader.ReadLine();
                        continue;
                    }

                    if (Regex.IsMatch(line, string.Format("\\[[0-9]+\\].*", index)))
                    {
                        // skip to the end, because it's the next entry
                        while (line != null)
                            line = reader.ReadLine();
                    }

                    if (line != null)
                    {
                        var match = Regex.Match(line,
                                                "([^ ]+) *([^ ]+) *([^ ]+) *([^ ]+) *([0-1]) *([^ ]+) *([^ ]+) *([^ ]+)");
                        if (match.Success)
                        {
                            InstanceFieldInfo instanceInfo = new InstanceFieldInfo();
                            instanceInfo.FieldAddress = match.Groups[1].Value;
                            instanceInfo.TypeName = match.Groups[4].Value;
                            instanceInfo.Attribut = match.Groups[6].Value;
                            instanceInfo.Value = match.Groups[7].Value;
                            instanceInfo.FieldName = match.Groups[8].Value;                            
                            result.Add(new CdbQueryable<InstanceFieldInfo>(instanceInfo, process));
                        }
                    }
                    line = reader.ReadLine();
                }
            }

            return result;
        }

        private IEnumerable<CdbQueryable<InstanceFieldInfo>> DumpObject(CdbProcess process)
        {
            var output = process.ExecuteCommand(string.Format("!DumpObj {0}", instanceAddress));
            StringReader reader = new StringReader(output);

            List<CdbQueryable<InstanceFieldInfo>> result = new List<CdbQueryable<InstanceFieldInfo>>();

            string line = reader.ReadLine();
            while (line != null)
            {
                if (Regex.Match(line, "0:005>.*").Success)
                {
                    line = reader.ReadLine();
                    continue;
                }

                while (line != null && !line.StartsWith("Fields:"))
                    line = reader.ReadLine();

                if (line == null)
                    continue;

                // skip the header of the array
                line = reader.ReadLine();

                // and read the next line
                line = reader.ReadLine();

                while (line != null)
                {
                    if (Regex.Match(line, " *>> Domain:Value.*").Success)
                    {
                        line = reader.ReadLine();
                        continue;
                    }

                    if (Regex.Match(line, "0:005>.*").Success)
                    {
                        line = reader.ReadLine();
                        continue;
                    }

                    var match = Regex.Match(line,
                                            "([^ ]+) *([^ ]+) *([^ ]+) *([^ ]+) *([0-1]) *([^ ]+) *([^ ]+) *([^ ]+)");
                    if (match.Success)
                    {
                        InstanceFieldInfo instanceInfo = new InstanceFieldInfo();
                        instanceInfo.FieldAddress = match.Groups[1].Value;
                        instanceInfo.TypeName = match.Groups[4].Value;
                        instanceInfo.Attribut = match.Groups[6].Value;
                        instanceInfo.Value = match.Groups[7].Value;
                        instanceInfo.FieldName = match.Groups[8].Value;                        
                        result.Add(new CdbQueryable<InstanceFieldInfo>(instanceInfo, process));
                    }

                    line = reader.ReadLine();
                }
            }

            return result;
        }
        #endregion
    }
}
