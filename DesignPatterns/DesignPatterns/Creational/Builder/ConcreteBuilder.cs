namespace DesignPatterns.Creational.Builder
{
	/// <summary>
	/// Class ConcreteBuilder.
	/// </summary>
	public class ConcreteBuilder : IBuilder
	{
		private Product _product = new Product();

		public ConcreteBuilder()
		{
			Reset();
		}

		/// <summary>
		/// Method Reset.
		/// </summary>
		public void Reset()
		{
			_product = new Product();
		}

		/// <summary>
		/// Method BuildPartA.
		/// </summary>
		public void BuildPartA()
		{
			_product.Add("PartA1");
		}

		/// <summary>
		/// Method BuildPartA.
		/// </summary>
		public void BuildPartB()
		{
			_product.Add("PartB1");
		}

		/// <summary>
		/// Method BuildPartA.
		/// </summary>
		public void BuildPartC()
		{
			_product.Add("PartC1");
		}

		/// <summary>
		///  Method GetProduct.
		/// </summary>
		/// <returns>Product</returns>
		public Product GetProduct()
		{
			Product result = this._product;

			Reset();

			return result;
		}
	}
}
