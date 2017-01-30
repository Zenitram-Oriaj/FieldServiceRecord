using System;
using SQLite;

namespace FieldServiceRecord
{
  public class Publisher
  {
    [PrimaryKey, AutoIncrement]
    public uint Id {
      get;
      set;
    }

    [NotNull]
    public string FirstName {
      get;
      set;
    }

    [NotNull]
    public string LastName {
      get;
      set;
    }

    public string EMail {
      get;
      set;
    }

    public string PhoneNumber {
      get;
      set;
    }

    [NotNull]
    public bool IsPrimary {
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

    public Publisher ()
    {
    }
  }
}
