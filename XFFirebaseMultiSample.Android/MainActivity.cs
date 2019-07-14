using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

using Firebase.Analytics;

namespace XFFirebaseMultiSample.Droid
{
    [Activity(Label = "XFFirebaseMultiSample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            var analytics = FirebaseAnalytics.GetInstance(this);

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            var bundle = new Bundle();
            bundle.PutString(FirebaseAnalytics.Param.ItemCategory, "Monday");
            bundle.PutString(FirebaseAnalytics.Param.ItemName, "21:54");
            bundle.PutInt(FirebaseAnalytics.Param.ItemId, 2154);
            analytics.LogEvent(FirebaseAnalytics.Event.SelectContent, bundle);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}