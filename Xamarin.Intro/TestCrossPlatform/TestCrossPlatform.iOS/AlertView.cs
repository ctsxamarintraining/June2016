using System;
using TestCrossPlatform.Core;
using UIKit;

namespace TestCrossPlatform.iOS
{
	public class AlertView:IAlertView
	{
		UIViewController _view;
		public AlertView(UIViewController view)
		{
			_view = view;
		}

		public void ShowAlert()
		{
			UIAlertController alert = UIAlertController.Create("Message", "Data Saved from PCL interface", UIAlertControllerStyle.Alert);

			// Configure the alert
			alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (action) => { }));

			// Display the alert
			_view.PresentViewController(alert, true, null);
		}
	}
}

