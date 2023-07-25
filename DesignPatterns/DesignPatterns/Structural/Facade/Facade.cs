namespace DesignPatterns.Structural.Facade;

public class Facade
{
	protected Subsystem1 _subsystem1;
        
	protected Subsystem2 _subsystem2;

	public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
	{
		_subsystem1 = subsystem1;
		_subsystem2 = subsystem2;
	}
        
	public string Operation()
	{
		string result = "Facade initializes subsystems:\n";
		result += _subsystem1.operation1();
		result += _subsystem2.operation1();
		result += "Facade orders subsystems to perform the action:\n";
		result += _subsystem1.operationN();
		result += _subsystem2.operationZ();
		return result;
	}
}
