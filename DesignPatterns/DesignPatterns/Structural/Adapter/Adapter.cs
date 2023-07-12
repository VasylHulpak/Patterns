namespace DesignPatterns.Structural.Adapter;

public class Adapter: ITarget
{
	private readonly Adaptee _adaptee;

	public Adapter(Adaptee adaptee)
	{
		_adaptee = adaptee;
	}

	public string GetRequest()
	{
		return $"This is '{_adaptee.GetSpecificRequest()}'";
	}
}
