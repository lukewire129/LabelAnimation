using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using Xamarin.Forms;

namespace LabelAnimation.ViewModel
{
	public class TimeLabelChangeViewModel : ObservableObject
	{
		private int _secnumber1 = 0;

		public int secnumber1
		{
			get => _secnumber1;
			set => SetProperty(ref _secnumber1, value);
		}
		private int _secnumber2 = 0;

		public int secnumber2
		{
			get => _secnumber2;
			set => SetProperty(ref _secnumber2, value);
		}

		private int _minnumber1= 0;

		public int minnumber1
		{
			get => _minnumber1;
			set => SetProperty(ref _minnumber1, value);
		}
		private int _minnumber2 = 0;

		public int minnumber2
		{
			get => _minnumber2;
			set => SetProperty(ref _minnumber2, value);
		}

		private int _hournumber1 = 0;

		public int hournumber1
		{
			get => _hournumber1;
			set => SetProperty(ref _hournumber1, value);
		}

		private int _hournumber2 = 0;

		public int hournumber2
		{
			get => _hournumber2;
			set => SetProperty(ref _hournumber2, value);
		}

		public TimeLabelChangeViewModel()
		{
			Device.StartTimer(new System.TimeSpan(0, 0, 1), () =>
			{
				var nowTime = DateTime.Now;

				var hour = nowTime.Hour.ToString("D2");
				var min = nowTime.Minute.ToString("D2");
				var sec = nowTime.Second.ToString("D2");

				hournumber1 = Convert.ToInt32(hour.Substring(0, 1));
				hournumber2 = Convert.ToInt32(hour.Substring(1, 1));
				minnumber1 = Convert.ToInt32(min.Substring(0, 1));
				minnumber2 = Convert.ToInt32(min.Substring(1, 1));
				secnumber1 = Convert.ToInt32(sec.Substring(0,1));
				secnumber2 = Convert.ToInt32(sec.Substring(1, 1));

				return true;
			});
		}
	}
}
