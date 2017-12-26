using Demos.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(Demos.UWP.FileSystem))]
namespace Demos.UWP
{
    public class FileSystem : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var localFolder = ApplicationData.Current.LocalFolder;
            var storageFile = await localFolder.CreateFileAsync(fileName);
            await FileIO.WriteTextAsync(storageFile, text);
        }
    }
}
