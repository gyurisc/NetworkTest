using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace NetworkTest
{
	public class NetworkTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("NetworkTableViewCell");

		public NetworkTableViewCell () : base (UITableViewCellStyle.Value1, Key)
		{
			// TODO: add subviews to the ContentView, set various colors, etc.
			TextLabel.Text = "TextLabel";
		}
	}
}

