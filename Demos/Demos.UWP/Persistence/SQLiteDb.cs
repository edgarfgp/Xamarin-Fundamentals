using Demos.Persistence;
using Demos.UWP.Persistence;
using SQLite;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]

namespace Demos.UWP.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = ApplicationData.Current.LocalFolder;
            var path = Path.Combine(documentsPath.ToString(), "MySQLite.DB3");

            return new SQLiteAsyncConnection(path);
        }
    }
}
