using System;
using System.Threading.Tasks;
using Dependency.iOS.Services;
using Dependency.Services;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(StorageiOS))]

namespace Dependency.iOS.Services
{
    public class StorageiOS : IStorage
    {
        public Task<UInt64> GetFreeSpace()
        {
            // var personalFolder = NSFileManager.DefaultManager.GetFileSystemAttributes(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            NSFileSystemAttributes applicationFolder = NSFileManager.DefaultManager.GetFileSystemAttributes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            var freeSpace = applicationFolder.FreeSize;
            var totalSpace = applicationFolder.Size;
            return Task.FromResult(applicationFolder.FreeSize);
        }
    }
}