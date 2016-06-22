using System;
using TestCrossPlatform.Core;
using TestCrossPlatform.Shared;
using UIKit;

namespace TestCrossPlatform.iOS
{
	public partial class ViewController : UIViewController
	{
		SharedClass sobj;
		PortableClass pobj;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			BtnSharedSave.TouchUpInside += delegate {
				sobj = new SharedClass(this);
				sobj.Show();
			};

			btnPCLSave.TouchUpInside += delegate {
				pobj = new PortableClass();

				pobj.OnShow += delegate {
					UIAlertController alert = UIAlertController.Create("Message", "Data Saved", UIAlertControllerStyle.Alert);

					// Configure the alert
					alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (action) => { }));

					// Display the alert
					this.PresentViewController(alert, true, null);
				};

				pobj.Show();

			};

			BtnPCLInterface.TouchUpInside += delegate
			{
				pobj = new PortableClass();
				pobj.ShowAlert(new AlertView(this));
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

