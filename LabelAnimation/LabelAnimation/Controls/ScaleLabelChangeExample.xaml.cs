using LabelAnimation.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabelAnimation.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScaleLabelChangeExample : ContentView
	{
		public ScaleLabelChangeExample()
		{
			InitializeComponent();
			this.BindingContext = App.Current.Services.GetService<TimeLabelChangeViewModel>();
		}
	}
}