using DesignPatterns.Creational.Abstract_Factory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory_Method;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Flyweight.Models;
using DesignPatterns.Structural.Proxy;
using Client = DesignPatterns.Structural.Bridge.Client;

// Pattern: Adapter
var adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);
Console.WriteLine("Adaptee interface is incompatible with the client.But with adapter client can call it's method.");
Console.WriteLine(target.GetRequest());

// Pattern: Bridge
var client = new Client();
Abstraction abstraction;
abstraction = new Abstraction(new ConcreteImplementationA());
client.ClientCode(abstraction);
Console.WriteLine();
abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
client.ClientCode(abstraction);
//

//Pattern: Composite
var cl = new ClientCompose();
var leaf = new Leaf();
Console.WriteLine("Client: I get a simple component:");
cl.ClientCode(leaf);
var tree = new Composite();
var branch1 = new Composite();
branch1.Add(new Leaf());
branch1.Add(new Leaf());
var branch2 = new Composite();
branch2.Add(new Leaf());
tree.Add(branch1);
tree.Add(branch2);
Console.WriteLine("Client: Now I've got a composite tree:");
cl.ClientCode(tree);
Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
cl.ClientCode2(tree, leaf);
//

// Pattern: Decorator
Console.WriteLine();
var clientDecorator = new ClientDecorator();
var concreteComponent = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
clientDecorator.ClientCode(concreteComponent);
var decorator1 = new ConcreteDecoratorA(concreteComponent);
var decorator2 = new ConcreteDecoratorB(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
clientDecorator.ClientCode(decorator2);
//

// Pattern: Facade
Subsystem1 subsystem1 = new Subsystem1();
Subsystem2 subsystem2 = new Subsystem2();
Facade facade = new Facade(subsystem1, subsystem2);
FacadeClient.ClientCode(facade);
//

//Pattern: flyweight
void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
{
	Console.WriteLine("\nClient: Adding a car to database.");

	var flyweight = factory.GetFlyweight(new Car {
		Color = car.Color,
		Model = car.Model,
		Company = car.Company
	});

	// The client code either stores or calculates extrinsic state and
	// passes it to the flyweight's methods.
	flyweight.Operation(car);
}
var factory = new FlyweightFactory(
	new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
	new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
	new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
	new Car { Company = "BMW", Model = "M5", Color = "red" },
	new Car { Company = "BMW", Model = "X6", Color = "white" }
);
factory.ListFlyweights();

addCarToPoliceDatabase(factory, new Car {
	Number = "CL234IR",
	Owner = "James Doe",
	Company = "BMW",
	Model = "M5",
	Color = "red"
});

addCarToPoliceDatabase(factory, new Car {
	Number = "CL234IR",
	Owner = "James Doe",
	Company = "BMW",
	Model = "X1",
	Color = "red"
});
factory.ListFlyweights();
//

// Pattern:Proxy
var proxyClient = new ProxyClient();
            
Console.WriteLine("Client: Executing the client code with a real subject:");
var realSubject = new RealSubject();
proxyClient.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
var proxy = new Proxy(realSubject);
proxyClient.ClientCode(proxy);
//

// Pattern: Factory Method
 new FactoryMethod().Main();
//

// Pattern: Abstract factory
new AbstractFactoryClient().Main();
//

// Pattern: Builder
var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;
            
Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListParts());
//
Console.ReadKey();
