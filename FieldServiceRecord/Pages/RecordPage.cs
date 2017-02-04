using System;

using Xamarin.Forms;
using FieldServiceRecord.Helpers;

namespace FieldServiceRecord
{
  public class RecordListPage : ContentPage
  {
    public RecordListPage ()
    {
      Title = "Record";
			Padding = ThemeSet.PadDevice;
			BackgroundColor = ThemeSet.BackgroundColor;
		}
  }

	public class RecordPage : ContentPage
	{
		public RecordPage() {
			Title = "Record";
			Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

			Content = new StackLayout {
				Children = {
					new Label { Text = "Record" }
				}
			};
		}
	}
}

