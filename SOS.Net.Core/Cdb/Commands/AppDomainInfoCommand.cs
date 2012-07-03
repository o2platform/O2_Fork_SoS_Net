using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SOS.Net.Core.Cdb.Commands
{
    public class AppDomainInfoCommand : ICdbCommand<CdbQueryable<AppDomainInfo>>
    {
        public IEnumerable<CdbQueryable<AppDomainInfo>> Result(CdbProcess process)
        {
            const string appDomainSeparator = "--------------------------------------";

            var output = process.ExecuteCommand("!DumpDomain");
            StringReader reader = new StringReader(output);

            List<CdbQueryable<AppDomainInfo>> result = new List<CdbQueryable<AppDomainInfo>>();

            string line = null;
            line = reader.ReadLine();
            do
            {
                if (line != null && line.Equals(appDomainSeparator))
                {
                    // inside a AppDomain
                    line = reader.ReadLine();

                    if (line.StartsWith("System Domain:") || line.StartsWith("Shared Domain:"))
                    {
                        do
                        {
                            line = reader.ReadLine();
                        } while (line != null && !line.Equals(appDomainSeparator));
                    }
                    else
                    {
                        var appDomainInfo = new CdbQueryable<AppDomainInfo>(new AppDomainInfo(), process);
                        result.Add(appDomainInfo);

                        appDomainInfo.Value.Address = Regex.Match(line, "Domain .*:(.*)").Groups[1].Value;

                        do
                        {
                            line = reader.ReadLine();
                            if (line != null && line.StartsWith("Name: "))
                            {
                                appDomainInfo.Value.Name = line.Substring("Name: ".Length);
                            }
                        } while (line != null && !line.Equals(appDomainSeparator));
                    }
                }
                else
                {
                    line = reader.ReadLine();
                }
            } while (line != null);

            return result;
        }
    }
}