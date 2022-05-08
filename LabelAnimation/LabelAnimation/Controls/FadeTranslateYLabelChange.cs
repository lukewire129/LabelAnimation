using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabelAnimation.Controls
{
	internal class FadeTranslateYLabelChange : Label
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

			await Task.WhenAny<bool>
			(
				label.TranslateTo(0, 10),
				label.FadeTo(0)
			);
			label.Text = (string)newValue;

			await label.TranslateTo(0, 0);
			await label.FadeTo(1);
		}
	}
}
