namespace DesignPatterns.Structural.Decorator
{
	public class Decorator : Component
	{
		private readonly Component _component;

		protected Decorator(Component component)
		{
			_component = component;
		}

		public override string Operation()
		{
			return _component.Operation();
		}
	}
}
