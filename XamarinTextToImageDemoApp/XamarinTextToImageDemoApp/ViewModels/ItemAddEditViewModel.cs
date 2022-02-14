using System;
using System.Collections.Generic;
using System.Text;
using XamarinTextToImageDemoApp.Repositories;

namespace XamarinTextToImageDemoApp.ViewModels
{
	public class ItemAddEditViewModel : ViewModelBase
	{
		private readonly CouponRepository _repository;

		public ItemAddEditViewModel(CouponRepository repository)
		{
			_repository = repository;
		}
	}
}
