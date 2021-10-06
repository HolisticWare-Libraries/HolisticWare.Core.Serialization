using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace UnitTests.Xamarin.Forms.MSTestX.Droid
{
    [Activity(Label = "UnitTests.Xamarin.Forms.MSTestX", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity
        :
        // global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
        global::MSTestX.TestRunnerActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //global::Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            //global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //LoadApplication(new App());

            return;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            global::Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
