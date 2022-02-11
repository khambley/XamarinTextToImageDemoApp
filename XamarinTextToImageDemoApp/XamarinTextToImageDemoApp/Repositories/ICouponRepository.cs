using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinTextToImageDemoApp.Models;

namespace XamarinTextToImageDemoApp.Repositories
{
	public interface ICouponRepository
	{
		event EventHandler<CouponItem> OnItemAdded;
		event EventHandler<CouponItem> OnItemUpdated;

		Task<List<CouponItem>> GetItems();
		Task AddItem(CouponItem item);
		Task UpdateItem(CouponItem item);
		Task AddOrUpdate(CouponItem item);
	}
}
