using System.Collections.Generic;
using SOS.Net.Core.Cdb.Commands;

namespace SOS.Net.Core.Cdb
{
    public static class AppDomainInfoExtensions
    {
        public static IEnumerable<AssemblyInfo> GetAssemblies(this CdbQueryable<AppDomainInfo> appDomainInfo)
        {
            return appDomainInfo.process.ExecuteCommand(new AssemblyInfoCommand(appDomainInfo.Value.Address));
        }
    }
}