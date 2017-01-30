using System;
using SQLite;

namespace FieldServiceRecord
{
  public class House
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

    public Symbols Symbol {
      get;
      set;
    }

    public string Notes {
      get;
      set;
    }

    public uint Attempts {
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


    public House ()
    {
    }
  }
}
