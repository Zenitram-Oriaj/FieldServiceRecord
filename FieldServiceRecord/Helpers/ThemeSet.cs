using System;
using System.Collections.Generic;
using Xamarin.Forms;
using FieldServiceRecord.Resx;

namespace FieldServiceRecord.Helpers
{
	public static class ThemeSet
	{
		private static Color _backgroundColor = Color.FromHex("222222");
		private static Color _textColor = Color.White;
		private static Color _detailColor = Color.FromHex("eeeeee");
		private static Color _boxColor = Color.FromHex("555555");

		public static Color BackgroundColor {
			get {
				return _backgroundColor;
			}
			set {
				_backgroundColor = value;
			}
		}
		public static Color TextColor {
			get {
				return _textColor;
			}
			set {
				_textColor = value;
			}
		}
		public static Color DetailColor {
			get {
				return _detailColor;
			}
			set {
				_detailColor = value;
			}
		}
		public static Color BoxColor {
			get {
				return _boxColor;
			}
			set {
				_boxColor = value;
			}
		}
		public static FontAttributes FontSet { get { return FontAttributes.Bold; } }
		public static double FontSizeLg { get { return 18; } }
		public static double FontSizeMd { get { return 14; } }
		public static double FontSizeSm { get { return 10; } }
		public static Thickness PadDevice {
			get {
				return new Thickness(
					Device.OnPlatform(0, 0, 0),  // Left
					Device.OnPlatform(20, 0, 0), // Top
					Device.OnPlatform(0, 0, 0),  // Right
					Device.OnPlatform(0, 0, 0)); // Bottom
			}
		}
		public static Thickness PadNone {
			get {
				return new Thickness(
					Device.OnPlatform(0, 0, 0),  // Left
					Device.OnPlatform(0, 0, 0), // Top
					Device.OnPlatform(0, 0, 0),  // Right
					Device.OnPlatform(0, 0, 0)); // Bottom
			}
		}

		public static void SetColorSchema(Schema mode) {
			switch (mode) {
				case Schema.Basic: {
						break;
					}
				case Schema.Light:
				default: {
						break;
					}
			}
		}

		public static Dictionary<int,string> GetColorSchemas() {
			var dict = new Dictionary<int, string>();

			dict.Add(0, LangResource.txtThemeDark);
			dict.Add(1, LangResource.txtThemeRose);
			dict.Add(2, LangResource.txtThemeOcean);
			dict.Add(3, LangResource.txtThemeDesert);
			dict.Add(4, LangResource.txtThemeLight);
			dict.Add(5, LangResource.txtThemeBasic);

			return dict;
		} 
	}
}
