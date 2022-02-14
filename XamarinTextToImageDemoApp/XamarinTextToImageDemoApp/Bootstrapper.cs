using Autofac;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using XamarinTextToImageDemoApp.ViewModels;
using XamarinTextToImageDemoApp.Views;
using XamarinTextToImageDemoApp.Repositories;

namespace XamarinTextToImageDemoApp
{
	public abstract class Bootstrapper
	{
		protected ContainerBuilder ContainerBuilder { get; private set; }

		public Bootstrapper()
		{
			Initialize();
			FinishInitialization();
		}

		protected virtual void Initialize()
		{
			var currentAssembly = Assembly.GetExecutingAssembly();
			ContainerBuilder = new ContainerBuilder();

			//inherited types = Page and ViewModelBase
			foreach (var type in currentAssembly.DefinedTypes
					.Where(e =>
					e.IsSubclassOf(typeof(Page)) ||
					e.IsSubclassOf(typeof(ViewModelBase))))
			{
				ContainerBuilder.RegisterType(type.AsType());
			}

			ContainerBuilder.RegisterType<CouponRepository>().SingleInstance();
		}

		private void FinishInitialization()
		{
			var container = ContainerBuilder.Build();
			Resolver.Initialize(container);
		}

	}
}
