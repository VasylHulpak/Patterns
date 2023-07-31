namespace DesignPatterns.Creational.Abstract_Factory
{
	/// <summary>
	/// Class ConcreteFactory2.
	/// </summary>
	public class ConcreteFactory2 : IAbstractFactory
	{
		/// <summary>
		/// Method CreateProductA.
		/// </summary>
		/// <returns>IAbstractProductA</returns>
		public IAbstractProductA CreateProductA()
		{
			return new ConcreteProductA2();
		}

		/// <summary>
		/// Method CreateProductA.
		/// </summary>
		/// <returns>IAbstractProductA</returns>
		public IAbstractProductB CreateProductB()
		{
			return new ConcreteProductB2();
		}
	}
}
