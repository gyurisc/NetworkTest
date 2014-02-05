using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using NetworkTest.Platform;

namespace NetworkTest
{
	public partial class NetworkDetailsViewControllers : DialogViewController
	{
		public NetworkDetailsViewControllers (NetworkInterfaceInformation interfaceInfo, bool pushing) : base (UITableViewStyle.Grouped, null, pushing)
		{
			Section addresses = new Section ("Addresses");
			foreach (var addr in interfaceInfo.Addresses) {
				addresses.Add(new StringElement(string.Empty, addr.ToString()));
			}

			Root = new RootElement ("Network Interface") {
				new Section ("General") {
					new StringElement ("Name", interfaceInfo.Name),
					new StringElement ("Type", interfaceInfo.Type.ToString()),
					new StringElement ("Mac address", interfaceInfo.MacAddressString)
				},
				addresses
			};
		}
	}
}
