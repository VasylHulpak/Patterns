// See https://aka.ms/new-console-template for more information

using DesignPatterns.Structural.Adapter;

// Pattern: Adapter
var adaptee = new Adaptee();

ITarget target = new Adapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());

//
