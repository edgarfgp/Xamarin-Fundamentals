using SQLite;

namespace Demos.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection(); 
    }
}
