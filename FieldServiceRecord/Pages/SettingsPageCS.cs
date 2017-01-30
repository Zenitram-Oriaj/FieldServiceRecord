using System;

using Xamarin.Forms;

namespace FieldServiceRecord
{
  public class SettingsPageCS : ContentPage
  {
    public SettingsPageCS ()
    {
      Title = "Settings";
      Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

      Content = new StackLayout {
        Children = {
          new Label { Text = "Settings" }
        }
      };
    }
  }
}

