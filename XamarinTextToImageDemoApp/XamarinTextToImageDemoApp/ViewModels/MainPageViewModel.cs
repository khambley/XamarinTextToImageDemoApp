using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinTextToImageDemoApp.Repositories;

namespace XamarinTextToImageDemoApp.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		private readonly CouponRepository _repository;

		public MainPageViewModel(CouponRepository repository)
		{
			_repository = repository;
			Task.Run(async () => await LoadData());
		}

		private async Task LoadData()
		{
			throw new NotImplementedException();
		}
	}
}
