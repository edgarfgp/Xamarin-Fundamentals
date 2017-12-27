using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Demos.Droid;
using Demos.IServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileSystem))]
namespace Demos.Droid
{
    public class FileSystem : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(docsPath, fileName);

            using (var writer = File.CreateText(path))
            {
                await writer.WriteAsync(text);
            }
        }

    }
}