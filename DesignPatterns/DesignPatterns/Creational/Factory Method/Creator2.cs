namespace DesignPatterns.Creational.Factory_Method
{
	/// <summary>
	/// Class Creator2.
	/// </summary>
	public class Creator2 : Creator
	{
		/// <summary>
		/// Method FactoryMethod.
		/// </summary>
		/// <returns>IProduct of Product2</returns>
		protected override IProduct FactoryMethod()
		{
			return new Product2();
		}
	}
}
