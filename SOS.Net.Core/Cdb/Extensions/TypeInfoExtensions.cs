using System.Collections.Generic;
using SOS.Net.Core.Cdb.Commands;

namespace SOS.Net.Core.Cdb
{
    public static class TypeInfoExtensions
    {
        public static IEnumerable<CdbQueryable<InstanceInfo>> GetInstances(this CdbQueryable<TypeInfo> typeInfo)
        {
            return typeInfo.process.ExecuteCommand(new InstanceInfoCommand(typeInfo.Value.Address));
        }
    }
}