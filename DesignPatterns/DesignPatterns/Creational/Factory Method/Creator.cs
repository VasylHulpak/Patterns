namespace DesignPatterns.Creational.Factory_Method
{
	/// <summary>
	/// Abstract class Creator.
	/// </summary>
	public abstract class Creator
	{
		/// <summary>
		/// Method factory method.
		/// </summary>
		/// <returns>IProduct</returns>
		protected abstract IProduct FactoryMethod();

		/// <summary>
		/// Method SomeOperation.
		/// </summary>
		/// <returns>string</returns>
		public string SomeOperation()
		{
			var product = FactoryMethod();
			var result = "Creator: The same creator's code has just worked with " + product.Operation();

			return result;
		}
	}
}
