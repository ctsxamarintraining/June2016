using System;

namespace TestCrossPlatform.Core
{
	public class PortableClass
	{
		public event EventHandler OnShow;
		public void Show()
		{
			SaveData();
			OnShow?.Invoke(null,null);	
		}

		void SaveData()
		{
			//Saving data to server
		}

		public void ShowAlert(IAlertView obj)
		{
			SaveData();
			obj.ShowAlert();
		}
}
}

