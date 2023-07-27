# Composite
Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.

## Real-World Analogy

<div align="center">

![](../../Images/composite.png)

</div>
Armies of most countries are structured as hierarchies. An army consists of several divisions; a division is a set of brigades, and a brigade consists of platoons, which can be broken down into squads. Finally, a squad is a small group of real soldiers. Orders are given at the top of the hierarchy and passed down onto each level until every soldier knows what needs to be done.
Example:

```
using System;

abstract class Component
{
    public Component() { }
  
    public abstract string Operation();

    public virtual void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(Component component)
    {
        throw new NotImplementedException();
    }

    public virtual bool IsComposite()
    {
        return true;
    }
}

class Leaf : Component
{
    public override string Operation()
    {
        return "Leaf";
    }

    public override bool IsComposite()
    {
        return false;
    }
}

class Composite : Component
{
    protected List<Component> _children = new List<Component>();
    
    public override void Add(Component component)
    {
        _children.Add(component);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override string Operation()
    {
        int i = 0;
        string result = "Branch(";

        foreach (Component component in _children)
        {
            result += component.Operation();
            if (i != _children.Count - 1)
            {
                result += "+";
            }
            i++;
        }
        
        return result + ")";
    }
}

class Client
{
    public void ClientCode(Component leaf)
    {
        Console.WriteLine($"RESULT: {leaf.Operation()}\n");
    }
    
    public void ClientCode2(Component component1, Component component2)
    {
        if (component1.IsComposite())
        {
            component1.Add(component2);
        }
        
        Console.WriteLine($"RESULT: {component1.Operation()}");
    }
}
```


MIT Licensed

**Copyright © 2023-present Vasyl Hulpak**
