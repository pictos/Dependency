using System;
using System.Threading.Tasks;
using Android.OS;
using Dependency.Droid.Services;
using Dependency.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(StorageAndroid))]

namespace Dependency.Droid.Services
{
    public class StorageAndroid : IStorage
    {
        public Task<UInt64> GetFreeSpace()
        {
            var path             = new StatFs(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData));
            long blockSize       = path.BlockSizeLong;
            long avaliableBlocks = path.AvailableBlocksLong;
            var produto          = (blockSize * avaliableBlocks).ToString();
            return Task.FromResult(UInt64.Parse(produto));
        }
    }
}