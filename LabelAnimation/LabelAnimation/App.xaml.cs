using LabelAnimation.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabelAnimation
{
	public partial class App : Application
	{
		public App()
		{
			Services = ConfigureServices();
			InitializeComponent();

			MainPage = new MainPage();
		}
		public new static App Current => (App)Application.Current;
		public IServiceProvider Services { get; }
		private static IServiceProvider ConfigureServices()
		{
			var services = new ServiceCollection();

			services.AddTransient<TimeLabelChangeViewModel>();

			return services.BuildServiceProvider();
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
