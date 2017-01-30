using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace FieldServiceRecord
{
  public class FSRDatabase
  {
    readonly SQLiteAsyncConnection _database;

    static FSRDatabase instance;
    static readonly object padlock = new object ();

    FSRDatabase ()
    {
      var str = DependencyService.Get<IFileHelper> ().GetLocalFilePath ("fsrdb.db3");
      _database = new SQLiteAsyncConnection (str);
    }

    public static FSRDatabase Current {
      get {
        lock (padlock) {
          if (instance == null) {
            instance = new FSRDatabase ();
          }
          return instance;
        }
      }
    }

    public async Task<string> Create ()
    {
      try {
        var a = await _database.CreateTableAsync<House> ();
        var b = await _database.CreateTableAsync<Street> ();
        var c = await _database.CreateTableAsync<Territory> ();
        var d = await _database.CreateTableAsync<Publisher> ();

        return "Database created";

      } catch (SQLiteException ex) {
        return ex.Message;
      }
    }


  }
}
