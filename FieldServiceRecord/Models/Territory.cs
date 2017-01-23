using System;
using System.Collections.Generic;
            
namespace FieldServiceRecord
{
  public class Territory
  {
    public int Id {
      get;
      set;
    }

    public List<Street> Streets {
      get;
      set;
    }

    public Publisher Owner {
      get;
      set;
    }

    public DateTime CheckedOut {
      get;
      set;
    }


    public Territory ()
    {
      
    }
  }
}
