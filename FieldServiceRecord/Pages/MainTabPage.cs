using System;

using Xamarin.Forms;

namespace FieldServiceRecord
{
  public class MainTabPageCS : TabbedPage
  {
    public MainTabPageCS ()
    {
      Title = "Home";

      Children.Add (new RecordListPage());
      Children.Add (new MapPage());
      Children.Add (new HistoryPage());
      Children.Add (new SettingsPage());
    }
  }
}

