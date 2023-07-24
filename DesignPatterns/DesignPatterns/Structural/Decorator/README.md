# Decorator
Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.
## Real-World Analogy

<div align="center">

![](../../Images/decorator.png)

</div>
Wearing clothes is an example of using decorators. When you’re cold, you wrap yourself in a sweater. If you’re still cold with a sweater, you can wear a jacket on top. If it’s raining, you can put on a raincoat. All of these garments “extend” your basic behavior but aren’t part of you, and you can easily take off any piece of clothing whenever you don’t need it.Example:

```sh
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
        this._children.Add(component);
    }

    public override void Remove(Component component)
    {
        this._children.Remove(component);
    }

    public override string Operation()
    {
        int i = 0;
        string result = "Branch(";

        foreach (Component component in this._children)
        {
            result += component.Operation();
            if (i != this._children.Count - 1)
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
}
```


MIT Licensed

**Copyright © 2023-present Vasyl Hulpak**
