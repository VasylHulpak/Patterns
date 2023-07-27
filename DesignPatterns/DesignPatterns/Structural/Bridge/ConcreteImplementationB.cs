namespace DesignPatterns.Structural.Bridge
{
	public class ConcreteImplementationB : IImplementation
	{
		public string OperationImplementation()
		{
			return "ConcreteImplementationA: The result in platform B.\n";
		}
	}
}
