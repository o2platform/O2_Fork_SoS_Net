using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SOS.Net.Core.Cdb.Commands
{
    public class TypeInfoCommand : ICdbCommand<CdbQueryable<TypeInfo>>
    {
        public IEnumerable<CdbQueryable<TypeInfo>> Result(CdbProcess process)
        {
            var output = process.ExecuteCommand("!dumpheap -stat");
            StringReader reader = new StringReader(output);

            List<CdbQueryable<TypeInfo>> result = new List<CdbQueryable<TypeInfo>>();

            string line = reader.ReadLine();
            while (line != null)
            {
                if (Regex.Match(line, ".*[tT]otal [0-9]+ objects.*").Success)
                {
                    line = reader.ReadLine();
                    continue;
                }

                if (Regex.Match(line, "0:005>.*").Success)
                {
                    line = reader.ReadLine();
                    continue;
                }

                var match = Regex.Match(line, "([^ ]+) *([0-9]+) *([0-9]+) *(.+)");
                if (match.Success)
                {
                    TypeInfo typeInfo = new TypeInfo
                                        {
                                            Address = match.Groups[1].Value,
                                            Count = match.Groups[2].Value,
                                            TotalSize = match.Groups[3].Value,
                                            ClassName = match.Groups[4].Value
                                        };
                    result.Add(new CdbQueryable<TypeInfo>(typeInfo, process));
                }
                line = reader.ReadLine();
            }

            return result;
        }
    }
}