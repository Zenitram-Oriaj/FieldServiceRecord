using System;

using Xamarin.Forms;

namespace FieldServiceRecord
{
  public class RecordPageCS : ContentPage
  {
    public RecordPageCS ()
    {
      Title = "Record";
      Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

      Content = new StackLayout {
        Children = {
          new Label { Text = "Record" }
        }
      };
    }
  }
}

