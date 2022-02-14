using System;
using System.Collections.Generic;
using System.Text;
using XamarinTextToImageDemoApp.Models;

namespace XamarinTextToImageDemoApp.ViewModels
{
	public class CouponItemViewModel : ViewModelBase
	{
		public CouponItemViewModel(CouponItem item) => item = item;

		public event EventHandler ItemStatusChanged;

		public CouponItem Item { get; private set; }

		public string StatusText => Item.IsUsed ? "Not Used" : "Used";
	}
}
