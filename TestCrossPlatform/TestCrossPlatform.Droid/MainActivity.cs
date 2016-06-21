using Android.App;
using Android.Widget;
using Android.OS;
using TestCrossPlatform.Shared;
using TestCrossPlatform.Core;

namespace TestCrossPlatform.Droid
{
	[Activity(Label = "TestCrossPlatform.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		SharedClass sobj;
		PortableClass pobj;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button1 = FindViewById<Button>(Resource.Id.SharedButton);

			button1.Click += delegate {
				sobj = new SharedClass(this);
				sobj.Show();
			};

			Button button2 = FindViewById<Button>(Resource.Id.PCLButton);

			button2.Click += delegate
			{
				pobj = new PortableClass();

				pobj.OnShow += delegate
				{
					Toast.MakeText(this, "Data Saved", ToastLength.Long).Show();
				};

				pobj.Show();

			};

			Button button3 = FindViewById<Button>(Resource.Id.PCLInterfaceButton);

			button3.Click += delegate
			{
				pobj = new PortableClass();
				pobj.ShowAlert(new AlertView(this));
			}; 
		}
	}
}


