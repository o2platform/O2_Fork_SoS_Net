using System.Collections.Generic;

namespace SOS.Net.Core.Cdb
{
    public interface ICdbCommand<T>
    {
        IEnumerable<T> Result(CdbProcess process);
    }
}