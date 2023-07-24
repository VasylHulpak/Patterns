namespace DesignPatterns.Structural.Decorator;

public class ClientDecorator
{
	public void ClientCode(Component component)
	{
		Console.WriteLine("RESULT: " + component.Operation());
	}
}
