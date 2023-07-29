namespace DesignPatterns.Structural.Bridge
{
	/// <summary>
	/// Class Abstraction.
	/// </summary>
	public class Abstraction
	{
		protected readonly IImplementation _implementation;
        
		/// <summary>
		/// <inheritdoc cref="Abstraction"/>
		/// </summary>
		/// <param name="implementation"></param>
		public Abstraction(IImplementation implementation)
		{
			_implementation = implementation;
		}
        
		/// <summary>
		/// Method Operation.
		/// </summary>
		/// <returns>string</returns>
		public virtual string Operation()
		{
			return "Abstract: Base operation with:\n" + 
			       _implementation.OperationImplementation();
		}
	}
}
