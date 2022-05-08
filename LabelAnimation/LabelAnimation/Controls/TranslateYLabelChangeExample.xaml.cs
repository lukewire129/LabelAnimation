using LabelAnimation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabelAnimation.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TranslateYLabelChangeExample : ContentView
	{
		public TranslateYLabelChangeExample()
		{
			InitializeComponent();
			this.BindingContext = App.Current.Services.GetService<TimeLabelChangeViewModel>();
		}
	}
}