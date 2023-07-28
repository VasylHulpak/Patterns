namespace DesignPatterns.Creational.Factory_Method;

/// <summary>
/// Class FactoryMethod.
/// </summary>
public class FactoryMethod
{
	/// <summary>
	/// Method Main for creating.
	/// </summary>
	public void Main()
	{
		Console.WriteLine("App: Launched with the ConcreteCreator1.");
		ClientCode(new Creator1());
            
		Console.WriteLine("");

		Console.WriteLine("App: Launched with the ConcreteCreator2.");
		ClientCode(new Creator2());
	}

	/// <summary>
	/// Method ClientCode.
	/// </summary>
	/// <param name="creator">Instance Creator.</param>
	private void ClientCode(Creator creator)
	{
		Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator.SomeOperation());
	}
}
