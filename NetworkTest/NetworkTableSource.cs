using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using NetworkTest.Platform;

namespace NetworkTest
{
	public class NetworkTableSource : UITableViewSource
	{
		static readonly string networkCellId = "NetworkCell";
		NetworkInterfaceInformation[] data; 
		UITableViewController controller; 

		public NetworkTableSource (NetworkInterfaceInformation[] interfaces, UITableViewController tvc)
		{
			controller = tvc; 
			data = interfaces;
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return data.Length;
		}			

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (networkCellId);

			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, networkCellId);

			cell.TextLabel.Text = data [indexPath.Row].Name;
			cell.DetailTextLabel.Text = data [indexPath.Row].MacAddressString; 


			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator; 

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath) {
			var interfaceInfo = data [indexPath.Row];

			controller.NavigationController.PushViewController (new NetworkDetailsViewControllers (interfaceInfo, true), true);
			tableView.DeselectRow (indexPath, true);
		}
	}
}

