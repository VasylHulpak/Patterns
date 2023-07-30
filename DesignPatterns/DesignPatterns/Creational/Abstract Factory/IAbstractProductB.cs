namespace DesignPatterns.Creational.Abstract_Factory;

/// <summary>
/// Interface IAbstractProductB.
/// </summary>
public interface IAbstractProductB
{
	/// <summary>
	/// Method UsefulFunctionB.
	/// </summary>
	/// <returns>string</returns>
	string UsefulFunctionB();

	/// <summary>
	/// Method AnotherUsefulFunctionB.
	/// </summary>
	/// <param name="collaborator">IAbstractProductA collaborator</param>
	/// <returns>string</returns>
	string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}
