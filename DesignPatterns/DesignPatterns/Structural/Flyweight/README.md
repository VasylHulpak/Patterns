﻿# Flyweight
Flyweight is a structural design pattern that lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.

### Flyweight and immutability
Since the same flyweight object can be used in different contexts, you have to make sure that its state can’t be modified. A flyweight should initialize its state just once, via constructor parameters. It shouldn’t expose any setters or public fields to other objects.
MIT Licensed

```
public class Flyweight
{
    private Car _sharedState;

    public Flyweight(Car car)
    {
        _sharedState = car;
    }

    public void Operation(Car uniqueState)
    {
        string s = JsonConvert.SerializeObject(this._sharedState);
        string u = JsonConvert.SerializeObject(uniqueState);
        Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
    }
}

public class FlyweightFactory
{
    private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

    public FlyweightFactory(params Car[] args)
    {
        foreach (var elem in args)
        {
            flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), getKey(elem)));
        }
    }

    public string getKey(Car key)
    {
        List<string> elements = new List<string>();

        elements.Add(key.Model);
        elements.Add(key.Color);
        elements.Add(key.Company);

        if (key.Owner != null && key.Number != null)
        {
            elements.Add(key.Number);
            elements.Add(key.Owner);
        }

        elements.Sort();

        return string.Join("_", elements);
    }

    public Flyweight GetFlyweight(Car sharedState)
    {
        string key = getKey(sharedState);

        if (flyweights.Where(t => t.Item2 == key).Count() == 0)
        {
            Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
            this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
        }
        return flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
    }

    public void listFlyweights()
    {
        var count = flyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
        foreach (var flyweight in flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}

public class Car
{
    public string Owner { get; set; }

    public string Number { get; set; }

    public string Company { get; set; }

    public string Model { get; set; }

    public string Color { get; set; }
}
```

**Copyright © 2023-present Vasyl Hulpak**
