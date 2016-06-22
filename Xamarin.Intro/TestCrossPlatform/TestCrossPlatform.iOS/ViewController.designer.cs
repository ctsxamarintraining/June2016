// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TestCrossPlatform.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnPCLInterface { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPCLSave { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnSharedSave { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BtnPCLInterface != null) {
                BtnPCLInterface.Dispose ();
                BtnPCLInterface = null;
            }

            if (btnPCLSave != null) {
                btnPCLSave.Dispose ();
                btnPCLSave = null;
            }

            if (BtnSharedSave != null) {
                BtnSharedSave.Dispose ();
                BtnSharedSave = null;
            }
        }
    }
}