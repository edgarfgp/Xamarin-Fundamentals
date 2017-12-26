using Demos.IServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.FileSystem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FileSystemPage : ContentPage
	{
		public FileSystemPage ()
		{
			InitializeComponent ();
            var fileSystem = DependencyService.Get<IFileSystem>();
            fileSystem.WriteTextAsync("test.txt", "hola");
            Debug.WriteLine(fileSystem.ToString());


        }
    }
}