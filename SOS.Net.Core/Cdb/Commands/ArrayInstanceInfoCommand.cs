using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SOS.Net.Core.Cdb.Commands
{
    public class ArrayInstanceInfoCommand : ICdbCommand<CdbQueryable<ArrayInstanceInfo>>
    {
        private string instanceAddress;

        public ArrayInstanceInfoCommand(string instanceAddress)
        {
            this.instanceAddress = instanceAddress;
        }

        #region ICdbCommand<CdbQueryable<ArrayInstanceInfo>> Members

        public IEnumerable<CdbQueryable<ArrayInstanceInfo>> Result(CdbProcess process)
        {
            var output = process.ExecuteCommand(string.Format("!DumpArray {0}", instanceAddress));
            StringReader reader = new StringReader(output);

            List<CdbQueryable<ArrayInstanceInfo>> result = new List<CdbQueryable<ArrayInstanceInfo>>();

            string line = reader.ReadLine();
            while (line != null)
            {
                while (line != null && !line.StartsWith("Element Methodtable"))
                    line = reader.ReadLine();

                // found, skip the line
                line = reader.ReadLine();

                if (line != null && Regex.Match(line, "0:005>.*").Success)
                {
                    line = reader.ReadLine();
                    continue;
                }

                while (line != null)
                {
                    var match = Regex.Match(line, "\\[([0-9]+)\\] *([^ ]+)");
                    if (match.Success)
                    {
                        ArrayInstanceInfo arrayInstanceInfo = new ArrayInstanceInfo
                        {
                            Number = match.Groups[1].Value,
                            Address = match.Groups[2].Value
                        };
                        result.Add(new CdbQueryable<ArrayInstanceInfo>(arrayInstanceInfo, process));
                    }

                    line = reader.ReadLine();
                }
            }

            return result;
        }

        #endregion
    }
}
