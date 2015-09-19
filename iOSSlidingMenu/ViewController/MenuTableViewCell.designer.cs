// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace iOSSlidingMenu
{
	[Register ("MenuTableViewCell")]
	partial class MenuTableViewCell
	{
		[Outlet]
		UIKit.UIImageView imgViewMenuIcon { get; set; }

		[Outlet]
		UIKit.UILabel lblMenuText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblMenuText != null) {
				lblMenuText.Dispose ();
				lblMenuText = null;
			}

			if (imgViewMenuIcon != null) {
				imgViewMenuIcon.Dispose ();
				imgViewMenuIcon = null;
			}
		}
	}
}
