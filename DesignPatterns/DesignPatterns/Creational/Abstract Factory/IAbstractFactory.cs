namespace DesignPatterns.Creational.Abstract_Factory
{
	/// <summary>
	/// Interface IAbstractFactory.
	/// </summary>
	public interface IAbstractFactory
	{
		/// <summary>
		/// Method CreateProductA.
		/// </summary>
		/// <returns>IAbstractProductA</returns>
		IAbstractProductA CreateProductA();

		/// <summary>
		/// Method CreateProductB.
		/// </summary>
		/// <returns>IAbstractProductB</returns>
		IAbstractProductB CreateProductB();
	}
}
