using System;

using Xamarin.Forms;
using FieldServiceRecord.Helpers;

namespace FieldServiceRecord
{
  public class HistoryPage : ContentPage
  {
    public HistoryPage ()
    {
      Title = "History";
			Padding = ThemeSet.PadDevice;
			BackgroundColor = ThemeSet.BackgroundColor;

			Content = new StackLayout {
        Children = {
          new Label { Text = "History" }
        }
      };
    }
  }
}

