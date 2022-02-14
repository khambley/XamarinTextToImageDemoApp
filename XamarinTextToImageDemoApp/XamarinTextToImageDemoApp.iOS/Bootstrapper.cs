using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace XamarinTextToImageDemoApp.iOS
{
	public class Bootstrapper : XamarinTextToImageDemoApp.Bootstrapper
	{
		public static void Init()
		{
			var instance = new Bootstrapper();
		}
	}
}