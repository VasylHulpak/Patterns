namespace DesignPatterns.Structural.Proxy
{
	public class RealSubject: ISubject
	{
		public void Request()
		{
			Console.WriteLine("RealSubject: Handling Request.");
		}
	}
}
