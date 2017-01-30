using System;

using Xamarin.Forms;

namespace FieldServiceRecord
{
  public class MainTabPageCS : TabbedPage
  {
    public MainTabPageCS ()
    {
      Title = "Home";

      Children.Add (new RecordPageCS());
      Children.Add (new MapPageCS());
      Children.Add (new HistoryPageCS());
      Children.Add (new SettingsPageCS());

    }
  }
}

