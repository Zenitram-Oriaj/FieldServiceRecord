using System;
using System.Collections.Generic;
using SQLite;

namespace FieldServiceRecord
{
  public class Street
  {
    [PrimaryKey, AutoIncrement]
    public uint Id {
      get;
      set;
    }

    [NotNull]
    public string Name
    {
      get;
      set;
    }

    public uint TerritoryId {
      get;
      set;
    }

    public uint PublisherId {
      get;
      set;
    }

    public int HouseCount {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the latitude.
    /// </summary>
    /// <value>The latitude.</value>
    public double Latitude {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the longitude.
    /// </summary>
    public double Longitude {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the potential position error radius in meters.
    /// </summary>
    public double Accuracy {
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


    public Street ()
    {
			Name = "";
			TerritoryId = 0;
			AddedOn = DateTime.Now;
    }
  }
}
