namespace DesignPatterns.Structural.Adapter
{
	/// <summary>
	/// Class Adapter.
	/// </summary>
	public class Adapter: ITarget
	{
		private readonly Adaptee _adaptee;

		/// <summary>
		/// <inheritdoc cref="Adapter"/>
		/// </summary>
		/// <param name="adaptee">Adaptee adaptee</param>
		public Adapter(Adaptee adaptee)
		{
			_adaptee = adaptee;
		}

		/// <summary>
		/// Method GetRequest.
		/// </summary>
		/// <returns>string</returns>
		public string GetRequest()
		{
			return $"This is '{_adaptee.GetSpecificRequest()}'";
		}
	}
}
