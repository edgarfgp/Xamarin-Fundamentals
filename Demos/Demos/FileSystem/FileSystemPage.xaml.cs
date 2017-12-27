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
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var fileSystem = DependencyService.Get<IFileSystem>();
            fileSystem.WriteTextAsync("test.txt", "hola");
            Debug.WriteLine(fileSystem.ToString());
        }
    }
}