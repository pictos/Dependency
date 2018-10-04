using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.Services
{
    public interface IStorage
    {
        Task<UInt64> GetFreeSpace();
    }
}
