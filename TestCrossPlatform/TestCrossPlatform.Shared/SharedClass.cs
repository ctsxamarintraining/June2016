using System;
#if __IOS__
using UIKit;
#elif __ANDROID__
using Android.Content;
using Android.Widget;
#endif
namespace TestCrossPlatform.Shared
{
	public class SharedClass
	{
		#if __IOS__
		UIViewController _view;
		public SharedClass(UIViewController view)
		{
			_view = view;
		}
#elif __ANDROID__
		Context _context;

		public SharedClass(Context context)
		{
			_context = context;
		}

#endif

		public void Show()
		{
			SaveData();

#if __IOS__
			UIAlertController alert = UIAlertController.Create("Message", "Data Saved", UIAlertControllerStyle.Alert);

			// Configure the alert
			alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (action) => { }));

			// Display the alert
			_view.PresentViewController(alert, true, null);

#elif __ANDROID__
			Toast.MakeText(_context, "Data Saved", ToastLength.Long).Show();
#endif

		}

		void SaveData()
		{
			//Saving data to server
		}
	}
}

