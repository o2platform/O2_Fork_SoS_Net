using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SOS.Net.Core.Cdb.Commands
{
    public class ReferenceInfoCommand :  ICdbCommand<CdbQueryable<ReferenceInfo>>
    {
        private readonly string instanceAddress;

        public ReferenceInfoCommand(string instanceAddress)
        {
            this.instanceAddress = instanceAddress;
        }

        public IEnumerable<CdbQueryable<ReferenceInfo>> Result(CdbProcess process)
        {
            var output = process.ExecuteCommand(string.Format("!GCRoot {0}", this.instanceAddress));

            var match = Regex.Match(output, string.Format("([A-Za-z0-9]*)\\(([^\\(]*)\\)->\\r\\n{0}", this.instanceAddress));

            var result = new List<CdbQueryable<ReferenceInfo>>();

            if(match.Success)
            {
                do
                {
                    var refInfo = new ReferenceInfo
                                  {
                                      Address = match.Groups[1].Value,
                                      Name = match.Groups[2].Value
                                  };
                    result.Add(new CdbQueryable<ReferenceInfo>(refInfo, process));
                } while ((match = match.NextMatch()).Success);
            }

            return result;
        }
    }
}
