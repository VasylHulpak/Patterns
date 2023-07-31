namespace DesignPatterns.Creational.Builder
{
	/// <summary>
	/// Class Director.
	/// </summary>
	public class Director
	{
		private IBuilder? _builder;
    
		public IBuilder? Builder
		{
			set { _builder = value; } 
		}
    
		/// <summary>
		/// Method BuildMinimalViableProduct.
		/// </summary>
		public void BuildMinimalViableProduct()
		{
			_builder?.BuildPartA();
		}
    
		/// <summary>
		/// Method BuildFullFeaturedProduct.
		/// </summary>
		public void BuildFullFeaturedProduct()
		{
			_builder?.BuildPartA();
			_builder?.BuildPartB();
			_builder?.BuildPartC();
		}
	}
}
