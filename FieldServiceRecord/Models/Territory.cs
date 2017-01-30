using System;
using System.Collections.Generic;
using SQLite;
            
namespace FieldServiceRecord
{
  public class Territory
  {
    [PrimaryKey, AutoIncrement]
    public uint Id {
      get;
      set;
    }

    [NotNull]
    public uint Number {
      get;
      set;
    }

    public string Name {
      get;
      set;
    }

    public uint PublisherId {
      get;
      set;
    }

    public DateTime CheckedOut {
      get;
      set;
    }

    public string City {
      get;
      set;
    }

    public string State {
      get;
      set;
    }

    public string ZipCode {
      get;
      set;
    }

    public DateTime AddedOn {
      get;
      set;
    }

    public DateTime UpdatedOn {
      get;
      set;
    }



    public Territory ()
    {
      
    }
  }
}
