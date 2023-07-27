namespace DesignPatterns.Structural.Facade
{
	public class FacadeClient
	{
		public static void ClientCode(Facade facade)
		{
			Console.Write(facade.Operation());
		}
	}
}
