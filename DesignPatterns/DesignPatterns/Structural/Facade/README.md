# Facade
Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.
## Real-World Analogy

<div align="center">

![img.png](../../Images/facade.png)An example of taking a phone order

</div>
When you call a shop to place a phone order, an operator is your facade to all services and departments of the shop. The operator provides you with a simple voice interface to the ordering system, payment gateways, and various delivery services.


```
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
        var result = "Facade initializes subsystems:\n";
        result += this._subsystem1.operation1();
        result += this._subsystem2.operation1();
        result += "Facade orders subsystems to perform the action:\n";
        result += this._subsystem1.operationN();
        result += this._subsystem2.operationZ();
        return result;
    }
}

public class Subsystem1
{
    public string operation1()
    {
        return "Subsystem1: Ready!\n";
    }

    public string operationN()
    {
        return "Subsystem1: Go!\n";
    }
}

public class Subsystem2
{
    public string operation1()
    {
        return "Subsystem2: Get ready!\n";
    }

    public string operationZ()
    {
        return "Subsystem2: Fire!\n";
    }
}

class Client
{
    public static void ClientCode(Facade facade)
    {
        Console.Write(facade.Operation());
    }
}
```

MIT Licensed

**Copyright © 2023-present Vasyl Hulpak**
