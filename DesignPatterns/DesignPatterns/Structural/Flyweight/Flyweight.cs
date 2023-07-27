using DesignPatterns.Structural.Flyweight.Models;
using Newtonsoft.Json;

namespace DesignPatterns.Structural.Flyweight
{
	public class Flyweight
	{
		private readonly Car _sharedState;

		public Flyweight(Car car)
		{
			_sharedState = car;
		}

		public void Operation(Car uniqueState)
		{
			var sharedObj = JsonConvert.SerializeObject(_sharedState);
			var uniqueObj = JsonConvert.SerializeObject(uniqueState);
			Console.WriteLine($"Flyweight: Displaying shared {sharedObj} and unique {uniqueObj} state.");
		}
	}
}
