# Adapter
Adapter is a structural design pattern, which allows incompatible objects to collaborate.

### Usage examples: 
The Adapter pattern is pretty common in C# code. It’s very often used in systems based on some legacy code. In such cases, Adapters make legacy code work with modern classes.

### Identification: 
Adapter is recognizable by a constructor which takes an instance of a different abstract/interface type. When the adapter receives a call to any of its methods, it translates parameters to the appropriate format and then directs the call to one or several methods of the wrapped object.

## Real-World Analogy

<div align="center">

![](../../Images/adapter.png)

</div>
When you travel from the US to Europe for the first time, you may get a surprise when trying to charge your laptop. The power plug and sockets standards are different in different countries. That’s why your US plug won’t fit a German socket. The problem can be solved by using a power plug adapter that has the American-style socket and the European-style plug.
Armies of most countries are structured as hierarchies. An army consists of several divisions; a division is a set of brigades, and a brigade consists of platoons, which can be broken down into squads. Finally, a squad is a small group of real soldiers. Orders are given at the top of the hierarchy and passed down onto each level until every soldier knows what needs to be done.

Example:

```
public interface ITarget
{
    string GetRequest();
}

public class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific request.";
    }
}

class Adapter : ITarget
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
```


MIT Licensed

**Copyright © 2023-present Vasyl Hulpak**
