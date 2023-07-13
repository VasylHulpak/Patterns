namespace DesignPatterns.Structural.Bridge;

public class Client
{
	public void ClientCode(Abstraction abstraction)
	{
		Console.Write(abstraction.Operation());
	}
}
