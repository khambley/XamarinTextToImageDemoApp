using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinTextToImageDemoApp.Models;
using SQLite;
using System.IO;

namespace XamarinTextToImageDemoApp.Repositories
{
	public class CouponRepository
	{
		private SQLiteAsyncConnection connection;
		
		public event EventHandler<CouponItem> OnItemAdded;
		public event EventHandler<CouponItem> OnItemUpdated;

		private async Task CreateConnection()
		{
			if(connection != null)
			{
				return;
			}

			var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var databasePath = Path.Combine(documentPath, "CouponItems.db");

			connection = new SQLiteAsyncConnection(databasePath);

			await connection.CreateTableAsync<CouponItem>();

			if(await connection.Table<CouponItem>().CountAsync() == 0)
			{
				await connection.InsertAsync(new CouponItem()
				{
					StoreName = "Pick'n Save",
					ExpirationDate = Convert.ToDateTime("02/24/2022"),
					ProductBrandName = "Atkins",
					ProductType = "multipack Bars, Cookies, Treats, or Shakes",
					Quantity = 5,
					Amount = 3.75M
				});
			}
		}
		public async Task<List<CouponItem>> GetItems()
		{
			await CreateConnection();
			return await connection.Table<CouponItem>().ToListAsync();
		}

		public async Task AddItem(CouponItem item)
		{
			// ensure we have a connection to the db
			await CreateConnection();

			// insert item into db
			await connection.InsertAsync(item);

			// notify any subscribers the item has been added
			OnItemAdded?.Invoke(this, item);
		}

		public async Task UpdateItem(CouponItem item)
		{
			// ensure we have a connection to the db
			await CreateConnection();

			// update item in db
			await connection.UpdateAsync(item);

			// notify any subscribers the item has been updated
			OnItemUpdated?.Invoke(this, item);
		}

		public async Task AddOrUpdate(CouponItem item)
		{
			if(item.Id == 0)
			{
				await AddItem(item);
			}
			else
			{
				await UpdateItem(item);
			}
		}
	}
}
