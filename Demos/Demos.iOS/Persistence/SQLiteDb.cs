using Demos.iOS.Persistence;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace Demos.iOS.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
    }
}