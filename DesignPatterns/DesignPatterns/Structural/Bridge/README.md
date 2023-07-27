# Bridge
Bridge is a structural design pattern that divides business logic or huge class into separate class hierarchies that can be developed independently.

One of these hierarchies (often called the Abstraction) will get a reference to an object of the second hierarchy (Implementation). The abstraction will be able to delegate some (sometimes, most) of its calls to the implementations object. Since all implementations will have a common interface, they’d be interchangeable inside the abstraction.



```
using System;

public class Abstraction
{
    protected IImplementation _implementation;
    
    public Abstraction(IImplementation implementation)
    {
        _implementation = implementation;
    }
    
    public virtual string Operation()
    {
        return "Abstract: Base operation with:\n" + 
            _implementation.OperationImplementation();
    }
}

public class ExtendedAbstraction : Abstraction
{
    public ExtendedAbstraction(IImplementation implementation) : base(implementation)
    {
    }
    
    public override string Operation()
    {
        return "ExtendedAbstraction: Extended operation with:\n" +
            base._implementation.OperationImplementation();
    }
}

public interface IImplementation
{
    string OperationImplementation();
}

public class ConcreteImplementationA : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform A.\n";
    }
}

public class ConcreteImplementationB : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform B.\n";
    }
}

public class Client
{
    public void ClientCode(Abstraction abstraction)
    {
        Console.Write(abstraction.Operation());
    }
}
```


MIT Licensed

**Copyright © 2023-present Vasyl Hulpak**
