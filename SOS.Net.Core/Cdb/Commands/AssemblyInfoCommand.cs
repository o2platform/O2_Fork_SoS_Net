using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SOS.Net.Core.Cdb.Commands
{
    public class AssemblyInfoCommand : ICdbCommand<AssemblyInfo>
    {
        private readonly string appDomainAddress;

        public AssemblyInfoCommand()
        {
            this.appDomainAddress = null;
        }

        public AssemblyInfoCommand(string appDomainAddress)
        {
            this.appDomainAddress = appDomainAddress;
        }

        public IEnumerable<AssemblyInfo> Result(CdbProcess process)
        {
            string output = null;
            if(!string.IsNullOrEmpty(this.appDomainAddress))
                output = process.ExecuteCommand(string.Format("!DumpDomain {0}", this.appDomainAddress));
            else
                output = process.ExecuteCommand(string.Format("!DumpDomain"));

            StringReader reader = new StringReader(output);

            List<AssemblyInfo> result = new List<AssemblyInfo>();

            string line = reader.ReadLine();
            while (line != null)
            {
                var match = Regex.Match(line, "Assembly: (.*) \\[(.*)\\]");
                if (match.Success)
                {
                    AssemblyInfo assemblyInfo = new AssemblyInfo();
                    assemblyInfo.Address = match.Groups[1].Value;
                    assemblyInfo.Name = match.Groups[2].Value;                                                
                    result.Add(assemblyInfo);
                }

                line = reader.ReadLine();
            }

            return result;
        }
    }
}