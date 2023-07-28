namespace DesignPatterns.Structural.Proxy
{
	public class Proxy : ISubject
	{
		private RealSubject _realSubject;

		public Proxy(RealSubject realSubject)
		{
			_realSubject = realSubject;
		}

		public void Request()
		{
			if (CheckAccess())
			{
				_realSubject.Request();

				LogAccess();
			}
		}

		public bool CheckAccess()
		{
			Console.WriteLine("Proxy: Checking access prior to firing a real request.");

			return true;
		}

		public void LogAccess()
		{
			Console.WriteLine("Proxy: Logging the time of request.");
		}
	}
}
