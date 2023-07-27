namespace DesignPatterns.Structural.Bridge
{
	public class ExtendedAbstraction: Abstraction
	{
		public ExtendedAbstraction(IImplementation implementation) : base(implementation)
		{
		}
        
		public override string Operation()
		{
			return "ExtendedAbstraction: Extended operation with:\n" +
			       _implementation.OperationImplementation();
		}
	}
}
