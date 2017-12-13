using Android.App;
using Android.Widget;
using Android.OS;

namespace SVGCompatibility.Droid
{
    [Activity(Label = "SVGCompatibility.Droid", MainLauncher = true, Theme = "@style/Theme.AppCompat.NoActionBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

