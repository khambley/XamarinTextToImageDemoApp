using System;
using SQLite;

namespace XamarinTextToImageDemoApp.Models
{
	public class CouponItem
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public DateTime ExpirationDate { get; set; }
		public string CouponImage { get; set; }
		public string ManufacturerName { get; set; }
		public string StoreName { get; set; }
		public string ProductBrandName { get; set; }
		public string ProductType { get; set; }
		public int Quantity { get; set; }
		public decimal Amount { get; set; }
		public string Description { get; set; }
		public DateTime ValidStartDate { get; set; }
		public bool IsUsed { get; set; }

	}
}
