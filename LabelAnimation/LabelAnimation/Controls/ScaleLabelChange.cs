using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabelAnimation.Controls
{
	public class ScaleLabelChange:Label
	{
		public static readonly BindableProperty AnimationTextProperty = BindableProperty.Create(nameof(AnimationText), typeof(string), typeof(ScaleLabelChange), null, BindingMode.TwoWay, propertyChanged: OnNameChanged);

		public string AnimationText
		{
			get => (string)GetValue(AnimationTextProperty);
			set => SetValue(AnimationTextProperty, value);
		}

		static async void OnNameChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var label = bindable as Label;
			await label.ScaleTo(0);
			label.Text = (string)newValue;
			await label.ScaleTo(1);
		}
	}
}
