namespace DesignPatterns.Creational.Factory_Method
{
	/// <summary>
	/// Class Creator1.
	/// </summary>
	public class Creator1 : Creator
	{
		/// <summary>
		/// Method FactoryMethod.
		/// </summary>
		/// <returns>IProduct of Product1</returns>
		protected override IProduct FactoryMethod()
		{
			return new Product1();
		}
	}
}
