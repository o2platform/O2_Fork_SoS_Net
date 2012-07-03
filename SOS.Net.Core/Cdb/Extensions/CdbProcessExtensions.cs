using System.Collections.Generic;
using SOS.Net.Core.Cdb.Commands;

namespace SOS.Net.Core.Cdb
{
    public static class CdbProcessExtensions
    {
        public static IEnumerable<CdbQueryable<AppDomainInfo>> GetAppDomains(this CdbProcess process)
        {
            return process.ExecuteCommand(new AppDomainInfoCommand());
        }

        public static IEnumerable<CdbQueryable<TypeInfo>> GetTypes(this CdbProcess process)
        {
            return process.ExecuteCommand(new TypeInfoCommand());
        }
    }
}