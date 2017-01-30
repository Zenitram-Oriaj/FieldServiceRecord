using System;

using Xamarin.Forms;

namespace FieldServiceRecord
{
  public class App : Application
  {
    public App ()
    {

      var a = FSRDatabase.Current.Create ().Result;
			MainPage = new MainTabPageCS();
    }

    protected override void OnStart ()
    {
      // Handle when your app starts
    }

    protected override void OnSleep ()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume ()
    {
      // Handle when your app resumes
    }
  }
}
