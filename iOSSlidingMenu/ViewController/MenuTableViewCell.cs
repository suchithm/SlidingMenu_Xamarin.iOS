
using System;
using Foundation;
using UIKit;

namespace iOSSlidingMenu
{
	public partial class MenuTableViewCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ( "MenuTableViewCell" , NSBundle.MainBundle );

		public static readonly NSString Key = new NSString ( "MenuTableViewCell" );

		public MenuTableViewCell ( IntPtr handle ) : base ( handle )
		{
		}

		public static MenuTableViewCell Create ()
		{
			return ( MenuTableViewCell ) Nib.Instantiate ( null , null ) [0];
		}
		internal void BindData(string strLabel,string strIconPath)
		{ 
			lblMenuText.Text =strLabel;
			imgViewMenuIcon.Image = UIImage.FromBundle ( strIconPath ); 
		}

	}
}

