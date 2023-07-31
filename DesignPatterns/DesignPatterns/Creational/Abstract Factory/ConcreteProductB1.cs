namespace DesignPatterns.Creational.Abstract_Factory
{
	/// <summary>
	/// Class ConcreteProductB1.
	/// </summary>
	public class ConcreteProductB1 : IAbstractProductB
	{
		/// <summary>
		/// Method UsefulFunctionB.
		/// </summary>
		/// <returns>string</returns>
		public string UsefulFunctionB()
		{
			return "The result of the product B1.";
		}

		/// <summary>
		/// Method AnotherUsefulFunctionB.
		/// </summary>
		/// <param name="collaborator">IAbstractProductA collaborator</param>
		/// <returns>string</returns>
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			var result = collaborator.UsefulFunctionA();

			return $"The result of the B1 collaborating with the ({result})";
		}
	}
}
