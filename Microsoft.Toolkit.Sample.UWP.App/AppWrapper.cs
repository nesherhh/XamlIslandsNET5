using System;

namespace Microsoft.Toolkit.Sample.UWP.App
{
	public class AppWrapper : IDisposable
	{
		private readonly App app;

		public AppWrapper()
		{
			app = new App();
		}
		public void Dispose()
		{
			app.Dispose();
		}
	}
}