using System;

using Xamarin.Forms;
using FieldServiceRecord.Helpers;

namespace FieldServiceRecord
{
  public class SettingsPage : ContentPage
  {
    public SettingsPage ()
    {
      Title = "Settings";
			Padding = ThemeSet.PadDevice;
			BackgroundColor = ThemeSet.BackgroundColor;

			Content = new StackLayout {
        Children = {
          new Label { Text = "Settings" }
        }
      };
    }
  }
}

