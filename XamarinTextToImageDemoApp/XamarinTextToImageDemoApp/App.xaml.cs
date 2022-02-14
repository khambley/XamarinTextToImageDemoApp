﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTextToImageDemoApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(Resolver.Resolve<MainPage>());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
