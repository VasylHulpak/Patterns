namespace DesignPatterns.Creational.Abstract_Factory
{
	/// <summary>
	/// Class AbstractFactoryClient.
	/// </summary>
	public class AbstractFactoryClient
	{
		/// <summary>
		/// Method Main.
		/// </summary>
		public void Main()
		{
			// The client code can work with any concrete factory class.
			Console.WriteLine("Client: Testing client code with the first factory type...");
			ClientMethod(new ConcreteFactory1());
			Console.WriteLine();

			Console.WriteLine("Client: Testing the same client code with the second factory type...");
			ClientMethod(new ConcreteFactory2());
		}

		/// <summary>
		/// Method ClientMethod.
		/// </summary>
		/// <param name="factory">IAbstractFactory factory</param>
		public void ClientMethod(IAbstractFactory factory)
		{
			var productA = factory.CreateProductA();
			var productB = factory.CreateProductB();

			Console.WriteLine(productB.UsefulFunctionB());
			Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
		}
	}
}
