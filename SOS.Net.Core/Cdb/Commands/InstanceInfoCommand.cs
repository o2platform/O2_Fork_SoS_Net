using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SOS.Net.Core.Cdb.Commands
{
    public class InstanceInfoCommand : ICdbCommand<CdbQueryable<InstanceInfo>>
    {
        private string typeAddress;

        public InstanceInfoCommand(string typeAddress)
        {
            this.typeAddress = typeAddress;
        }

        public IEnumerable<CdbQueryable<InstanceInfo>> Result(CdbProcess process)
        {
            var output = process.ExecuteCommand(string.Format("!DumpHeap -mt {0}", this.typeAddress));
            StringReader reader = new StringReader(output);

            List<CdbQueryable<InstanceInfo>> result = new List<CdbQueryable<InstanceInfo>>();

            string line = reader.ReadLine();
            while (line != null)
            {
                if (Regex.Match(line, "0:005>.*").Success)
                {
                    line = reader.ReadLine();
                    continue;
                }

                if (Regex.Match(line, ".*[tT]otal [0-9]+ objects.*").Success)
                {
                    break;
                }

                var match = Regex.Match(line, "([^ ]+) *([^ ]+) *([0-9]+) *");
                if (match.Success)
                {
                    InstanceInfo instanceInfo = new InstanceInfo
                                                {
                                                    Address = match.Groups[1].Value,
                                                    Size = match.Groups[3].Value
                                                };
                    result.Add(new CdbQueryable<InstanceInfo>(instanceInfo, process));
                }

                line = reader.ReadLine();
            }

            return result;
        }
    }
}