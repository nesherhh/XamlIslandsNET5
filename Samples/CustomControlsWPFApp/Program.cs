using System;

namespace CustomControlsWPFApp
{
	public class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			using (var uwpApp = new CustomControlsWrapper.App())
			{
				var app = new App();
				app.Run();
			}
		}
	}
}