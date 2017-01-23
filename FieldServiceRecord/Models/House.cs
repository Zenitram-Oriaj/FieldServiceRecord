using System;

namespace FieldServiceRecord
{
  public class House
  {
    public uint Number {
      get;
      set;
    }

    public DateTime Date {
      get;
      set;
    }

    public  Symbols Symbol {
      get;
      set;
    }

    public string Notes {
      get;
      set;
    }

    public int Attempts {
      get;
      set;
    }

    public House ()
    {
    }
  }
}
