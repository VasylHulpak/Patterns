namespace DesignPatterns.Creational.Factory_Method;

public class ClientFactoryMethod
{
	public void Main()
	{
		Console.WriteLine("App: Launched with the ConcreteCreator1.");
		ClientCode(new ConcreteCreator1());
            
		Console.WriteLine("");

		Console.WriteLine("App: Launched with the ConcreteCreator2.");
		ClientCode(new ConcreteCreator2());
	}

	public void ClientCode(Creator creator)
	{
		Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator.SomeOperation());
	}
}
