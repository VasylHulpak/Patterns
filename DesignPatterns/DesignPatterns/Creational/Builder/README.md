# Builder
Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

```csharp
public interface IBuilder
{
    void BuildPartA();
    
    void BuildPartB();
    
    void BuildPartC();
}

public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();
    
    public ConcreteBuilder()
    {
        Reset();
    }
    
    public void Reset()
    {
        _product = new Product();
    }
    
    public void BuildPartA()
    {
        _product.Add("PartA1");
    }
    
    public void BuildPartB()
    {
        _product.Add("PartB1");
    }
    
    public void BuildPartC()
    {
        _product.Add("PartC1");
    }
    
    public Product GetProduct()
    {
        Product result = this._product;

        Reset();

        return result;
    }
}

public class Product
{
    private List<object> _parts = new List<object>();
    
    public void Add(string part)
    {
        _parts.Add(part);
    }
    
    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < this._parts.Count; i++)
        {
            str += this._parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2); 

        return "Product parts: " + str + "\n";
    }
}

public class Director
{
    private IBuilder _builder;
    
    public IBuilder Builder
    {
        set { _builder = value; } 
    }
    
    public void BuildMinimalViableProduct()
    {
        _builder.BuildPartA();
    }
    
    public void BuildFullFeaturedProduct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}
```

MIT Licensed

**Copyright © 2023-present Vasyl Hulpak**
