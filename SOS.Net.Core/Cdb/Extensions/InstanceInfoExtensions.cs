using System.Linq;
using SOS.Net.Core.Cdb.Commands;
using System.Collections.Generic;

namespace SOS.Net.Core.Cdb
{
    public static class InstanceInfoExtensions 
    {
        public static CdbQueryable<InstanceInfoDetails> GetDetails(CdbQueryable<InstanceInfo> instanceInfo)
        {
            return
                instanceInfo.process.ExecuteCommand(new InstanceInfoDetailsCommand(instanceInfo.Value.Address)).First();
        }

        public static IEnumerable<CdbQueryable<InstanceFieldInfo>> GetFields(CdbQueryable<InstanceInfo> instanceInfo)
        {
            return instanceInfo.process.ExecuteCommand(new InstanceFieldInfoCommand(instanceInfo.Value.Address));
        }
    }
}