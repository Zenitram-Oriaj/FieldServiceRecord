using System;
using System.Collections.Generic;

namespace FieldServiceRecord
{
  public class Street
  {
    public string Name
    {
      get;
      set;
    }

    public int TerritoryId {
      get;
      set;
    }

    public Publisher Publisher {
      get;
      set;
    }

    public List<House> Houses {
      get;
      set;
    }

    public Street ()
    {
      
    }
  }
}
