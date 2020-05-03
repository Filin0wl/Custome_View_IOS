using Foundation;
using System;
using UIKit;

namespace Custome_View_IOS
{
    public partial class ViewController : UIViewController
    {
        Rating_View v;

        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.

            v = Rating_View.Create();
            v.Frame = View.Frame;
            View.AddSubview(v);
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.

           
        }
    }
}