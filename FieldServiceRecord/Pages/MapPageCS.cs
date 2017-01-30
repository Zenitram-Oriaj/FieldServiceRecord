using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Plugin.Geolocator;
using System.Diagnostics;
using System.Linq;

namespace FieldServiceRecord
{
  public class MapPageCS : ContentPage
  {
    Geocoder geoCoder;
    Position position;
    Map map;
    Label lblAddr;

    public MapPageCS ()
    {

      Title = "Map";
      Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

      map = new Map (MapSpan.FromCenterAndRadius (new Position (37, -122), Distance.FromMiles (1))) {
        IsShowingUser = true,
        MapType = MapType.Street,
        HeightRequest = 100,
        WidthRequest = 960,
        VerticalOptions = LayoutOptions.FillAndExpand
      };



      lblAddr = new Label {
        Text = "WAITING"
      };


      var stack = new StackLayout { Spacing = 0 };
      stack.Children.Add (map);
      stack.Children.Add (lblAddr);
      Content = stack;
    }

    protected async override void OnAppearing ()
    {
      base.OnAppearing ();

      var locator = CrossGeolocator.Current;
      locator.DesiredAccuracy = 30;

      var pos = await locator.GetPositionAsync (10000);

      position = new Position (pos.Latitude, pos.Longitude);
      geoCoder = new Geocoder ();

      var locations = await geoCoder.GetAddressesForPositionAsync (position);
      map.MoveToRegion (MapSpan.FromCenterAndRadius(position,Distance.FromMiles (0.3)));

      if (locations.Count() > 0) {
      }

      foreach (var item in locations) {
        var val = item.Split ('\n');
        lblAddr.Text = string.Format ("Possible :: {0}", val[0]);
      }
    }
  }
}
