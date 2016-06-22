using System;
using Android.Content;
using Android.Widget;
using TestCrossPlatform.Core;

namespace TestCrossPlatform.Droid
{
	public class AlertView : IAlertView
	{
		Context _context;

		public AlertView(Context context)
		{
			_context = context;
		}
		public void ShowAlert()
		{
			Toast.MakeText(_context, "Data Saved from PCL interface", ToastLength.Long).Show();
		}
	}
}

