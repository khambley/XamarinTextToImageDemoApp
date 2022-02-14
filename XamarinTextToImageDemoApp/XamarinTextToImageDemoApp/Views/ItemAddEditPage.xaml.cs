using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTextToImageDemoApp.ViewModels;

namespace XamarinTextToImageDemoApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemAddEditPage : ContentPage
	{
		public ItemAddEditPage(ItemAddEditViewModel viewModel)
		{
			InitializeComponent();
			viewModel.Navigation = Navigation;
			BindingContext = viewModel;
		}
	}
}