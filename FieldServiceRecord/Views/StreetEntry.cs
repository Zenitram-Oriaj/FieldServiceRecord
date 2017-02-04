using System;
using Xamarin.Forms;
using FieldServiceRecord.Resx;

namespace FieldServiceRecord.Views
{
	public class StreetEdit : ContentView
	{
		Label lblStreetHdr;
		Entry tbxStreetVal;
		StackLayout stkStreetName;

		Label lblTerrHdr;
		Entry tbxTerrVal;
		StackLayout stkTerr;

		Label lblPublisherHdr;
		Entry tbxPublisherVal;
		StackLayout stkPublisherName;

		public StreetEdit() {

			BuildStreetName();

			Content = new StackLayout {
				Children = {

				}
			};
		}

		private void BuildStreetName() {

			lblStreetHdr = new Label {
				Text = LangResource.txtStreet,
					
			};

			tbxStreetVal = new Entry {
				Placeholder = LangResource.txtStreetPlaceHolder,
				Keyboard = Keyboard.Default
			};

			tbxStreetVal.SetBinding(Entry.TextProperty, "Name");
		}
	}

	public class StreetView : ContentView
	{
		Label lblStreetHdr;
		Label lblStreetVal;
		StackLayout stkStreetName;

		Label lblDateHdr;
		Label lblDateVal;
		StackLayout stkDate;
		public StreetView() {

		}
	}
}
