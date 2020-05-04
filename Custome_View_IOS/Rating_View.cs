using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ObjCRuntime;
using System.Collections.Generic;

namespace Custome_View_IOS
{
    public partial class Rating_View : UIView
    {
        private List<UIButton> btnList;
        private int rating = 0;
        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value <= 0)
                    rating = 0;
                else if (value >= 5)
                    rating = 5;
                else
                    rating = value;

            }
        }
        public Rating_View(IntPtr handle) : base(handle)
        {

        }

        public static Rating_View Create()
        {
            var arr = NSBundle.MainBundle.LoadNib("Rating_View", null, null);
            var v = Runtime.GetNSObject<Rating_View>(arr.ValueAt(0));

            return v;
        }

        private void OnStarClick(int rating)
        {
            for (int i = 0; i < btnList.Count; i++)
            {
                btnList[i].Selected = (i < rating);
            }
        }
        public override void AwakeFromNib()
        {
            btnList = new List<UIButton>(){
                starButton1,
                starButton2,
                starButton3,
                starButton4,
                starButton5
            };




        }

        partial void StarButton5_TouchUpInside(UIButton sender)
        {
            OnStarClick(5);
        }

        partial void StarButton2_TouchUpInside(UIButton sender)
        {
            OnStarClick(2);
        }

        partial void StarButton3_TouchUpInside(UIButton sender)
        {
            OnStarClick(3);
        }

        partial void StarButton4_TouchUpInside(UIButton sender)
        {
            OnStarClick(4);
        }

        partial void StarButton1_TouchUpInside(UIButton sender)
        {
            OnStarClick(1);
        }
    }
}