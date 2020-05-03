using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ObjCRuntime;

namespace Custome_View_IOS
{
    public partial class Rating_View : UIView
    {
        public Rating_View (IntPtr handle) : base (handle)
        {
            
        }

        public static Rating_View Create()
        {
            var arr = NSBundle.MainBundle.LoadNib("Rating_View", null, null);
            var v = Runtime.GetNSObject<Rating_View>(arr.ValueAt(0));
            return v;
        }

        public override void AwakeFromNib()
        {
            
            
            
        }

        
    }
}