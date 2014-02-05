using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using NetworkTest.Platform;

namespace NetworkTest
{
	public class NetworkTableViewController : UITableViewController
	{
		public NetworkTableViewController () : base (UITableViewStyle.Plain)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			Title = "Network Interfaces";
			NetworkInterfaceInformation[] interfaces = MacOsNetworkInterface.GetIpAddressTable ();						
			TableView.Source = new NetworkTableSource (interfaces, this);
		}
	}
}

