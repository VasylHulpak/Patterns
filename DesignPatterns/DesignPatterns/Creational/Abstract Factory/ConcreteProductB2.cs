namespace DesignPatterns.Creational.Abstract_Factory
{
	/// <summary>
	/// Class ConcreteProductB2.
	/// </summary>
	public class ConcreteProductB2 : IAbstractProductB
	{
		/// <summary>
		/// Method UsefulFunctionB.
		/// </summary>
		/// <returns>string</returns>
		public string UsefulFunctionB()
		{
			return "The result of the product B2.";
		}

		/// <summary>
		/// Method AnotherUsefulFunctionB.
		/// </summary>
		/// <param name="collaborator">IAbstractProductA collaborator</param>
		/// <returns>string</returns>
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			var result = collaborator.UsefulFunctionA();

			return $"The result of the B2 collaborating with the ({result})";
		}
	}
}
