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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnBottom { get; set; }

		[Outlet]
		UIKit.UIButton btnIcon { get; set; }

		[Outlet]
		UIKit.UIImageView imgViewActionIcon { get; set; }

		[Outlet]
		UIKit.UITableView tableViewLeftMenu { get; set; }

		[Outlet]
		UIKit.UILabel txtActionBarText { get; set; }

		[Outlet]
		UIKit.UILabel txtDescription { get; set; }

		[Outlet]
		UIKit.UIView viewDecriptionContainer { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnIcon != null) {
				btnIcon.Dispose ();
				btnIcon = null;
			}

			if (imgViewActionIcon != null) {
				imgViewActionIcon.Dispose ();
				imgViewActionIcon = null;
			}

			if (txtActionBarText != null) {
				txtActionBarText.Dispose ();
				txtActionBarText = null;
			}

			if (txtDescription != null) {
				txtDescription.Dispose ();
				txtDescription = null;
			}

			if (viewDecriptionContainer != null) {
				viewDecriptionContainer.Dispose ();
				viewDecriptionContainer = null;
			}

			if (btnBottom != null) {
				btnBottom.Dispose ();
				btnBottom = null;
			}

			if (tableViewLeftMenu != null) {
				tableViewLeftMenu.Dispose ();
				tableViewLeftMenu = null;
			}
		}
	}
}
