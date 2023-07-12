# Adapter
Adapter is a structural design pattern, which allows incompatible objects to collaborate.

### Usage examples: 
The Adapter pattern is pretty common in C# code. It’s very often used in systems based on some legacy code. In such cases, Adapters make legacy code work with modern classes.

### Identification: 
Adapter is recognizable by a constructor which takes an instance of a different abstract/interface type. When the adapter receives a call to any of its methods, it translates parameters to the appropriate format and then directs the call to one or several methods of the wrapped object.


MIT Licensed

**Copyright © 2023-present Vasyl Hulpak**
