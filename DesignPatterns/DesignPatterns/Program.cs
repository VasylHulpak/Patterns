// See https://aka.ms/new-console-template for more information

using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using Client = DesignPatterns.Structural.Bridge.Client;

// Pattern: Adapter
var adaptee = new Adaptee();

ITarget target = new Adapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());

// Pattern: Bridge
Client client = new Client();

Abstraction abstraction;
// The client code should be able to work with any pre-configured
// abstraction-implementation combination.
abstraction = new Abstraction(new ConcreteImplementationA());
client.ClientCode(abstraction);
            
Console.WriteLine();
            
abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
client.ClientCode(abstraction);
//

//Pattern: Composite
var cl = new ClientCompose();

// This way the client code can support the simple leaf
// components...
var leaf = new Leaf();
Console.WriteLine("Client: I get a simple component:");
cl.ClientCode(leaf);

// ...as well as the complex composites.
var tree = new Composite();
var branch1 = new Composite();
branch1.Add(new Leaf());
branch1.Add(new Leaf());
Composite branch2 = new Composite();
branch2.Add(new Leaf());
tree.Add(branch1);
tree.Add(branch2);
Console.WriteLine("Client: Now I've got a composite tree:");
cl.ClientCode(tree);

Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
cl.ClientCode2(tree, leaf);
//

// Pattern: Decorator

var clientDecorator = new ClientDecorator();

var concreteComponent = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
clientDecorator.ClientCode(concreteComponent);
Console.WriteLine();

// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.
ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(concreteComponent);
ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
clientDecorator.ClientCode(decorator2);
//
