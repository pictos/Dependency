using Dependency.Services;
using Dependency.UWP.Services;
using System;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(StorageUWP))]
namespace Dependency.UWP.Services
{
    public class StorageUWP : IStorage
    {
        public async Task<UInt64> GetFreeSpace()
        {
            try
            {
                var local = ApplicationData.Current.LocalFolder;
                var retrivedProperties = await local.Properties.RetrievePropertiesAsync(new string[] { "System.FreeSpace" });

                //For external storage
             //   var folders = await KnownFolders.RemovableDevices.GetFoldersAsync();

                return (UInt64)retrivedProperties["System.FreeSpace"];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        //public async Task<UInt64> GetFreeSpace(StorageFolder folder)
        //{
        //    var retrivedProperties = await folder.Properties.RetrievePropertiesAsync(new string[] { "System.FreeSpace" });
        //    return (UInt64)retrivedProperties["System.FreeSpace"];
        //}

        //// and use it like this:
        //UInt64 spaceOfInstallationFolder = await GetFreeSpace(ApplicationData.Current.LocalFolder);
        //UInt64 spaceOfMusicLibrary = await GetFreeSpace(KnownFolders.MusicLibrary);
    }
}
