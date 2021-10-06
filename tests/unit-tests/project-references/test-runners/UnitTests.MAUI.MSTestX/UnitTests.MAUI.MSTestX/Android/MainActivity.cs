using Android.App;
using Android.Content.PM;
using Microsoft.Maui;

namespace UnitTests.MAUI.MSTestX
{
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
	public class MainActivity
		:
		// MauiAppCompatActivity
        // global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
        global::MSTestX.TestRunnerActivity
	{
	}
}