namespace DesignPatterns.Structural.Decorator;

public class ConcreteDecoratorA: Decorator
{
	public ConcreteDecoratorA(Component comp) : base(comp)
	{
	}

	public override string Operation()
	{
		return $"ConcreteDecoratorA({base.Operation()})";
	}
}
