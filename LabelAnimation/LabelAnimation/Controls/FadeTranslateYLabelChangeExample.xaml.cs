using LabelAnimation.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabelAnimation.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FadeTranslateYLabelChangeExample : ContentView
	{
		public FadeTranslateYLabelChangeExample()
		{
			InitializeComponent();
			this.BindingContext = App.Current.Services.GetService<TimeLabelChangeViewModel>();
		}
	}
}