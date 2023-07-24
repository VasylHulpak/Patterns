namespace DesignPatterns.Structural.Decorator;

public class ConcreteDecoratorB: Decorator
{
	public ConcreteDecoratorB(Component comp) : base(comp)
	{
	}

	public override string Operation()
	{
		return $"ConcreteDecoratorB({base.Operation()})";
	}
}
