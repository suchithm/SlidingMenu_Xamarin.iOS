using System;
using UIKit;

namespace iOSSlidingMenu
{
	public class MenuTableSourceClass :UITableViewSource
	{
		readonly string[] arrMenuText;
		readonly string[] arrMenuIcon;
		internal event Action<string> MenuSelected;

		public MenuTableSourceClass ()
		{
			arrMenuText=ConstantsClass.arrMenuText;
			arrMenuIcon = ConstantsClass.arrMenuIcon;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return arrMenuText.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			MenuTableViewCell cell = tableView.DequeueReusableCell ( MenuTableViewCell.Key ) as MenuTableViewCell ?? MenuTableViewCell.Create ();
			cell.BindData (arrMenuText[indexPath.Row],arrMenuIcon[indexPath.Row]);
			return cell; 
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			if ( MenuSelected != null )
				MenuSelected (arrMenuText[indexPath.Row]);

			tableView.DeselectRow (indexPath,true);
		}

		public override UIView GetViewForFooter (UITableView tableView, nint section)
		{
			return new UIView ();
		}

	}
}

