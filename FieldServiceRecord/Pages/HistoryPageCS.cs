using System;

using Xamarin.Forms;

namespace FieldServiceRecord
{
  public class HistoryPageCS : ContentPage
  {
    public HistoryPageCS ()
    {
      Title = "History";
      Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

      Content = new StackLayout {
        Children = {
          new Label { Text = "History" }
        }
      };
    }
  }
}

