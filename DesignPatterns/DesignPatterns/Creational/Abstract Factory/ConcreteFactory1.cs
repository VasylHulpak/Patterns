namespace DesignPatterns.Creational.Abstract_Factory;

/// <summary>
/// Class ConcreteFactory1.
/// </summary>
public class ConcreteFactory1 : IAbstractFactory
{
	/// <summary>
	/// Method CreateProductA.
	/// </summary>
	/// <returns>IAbstractProductA</returns>
	public IAbstractProductA CreateProductA()
	{
		return new ConcreteProductA1();
	}

	/// <summary>
	/// Method CreateProductB.
	/// </summary>
	/// <returns>IAbstractProductB</returns>
	public IAbstractProductB CreateProductB()
	{
		return new ConcreteProductB1();
	}
}
