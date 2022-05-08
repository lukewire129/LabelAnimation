using Xamarin.Forms;

namespace LabelAnimation.Controls
{
	public class TranslateYLabelChange:Label
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
			await label.TranslateTo(0,10);
			label.Text = (string)newValue;
			await label.TranslateTo(0, 0);
		}
	}
}
