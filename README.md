# ZOO

A hierarchical class structure of a zoo that contains 3 layers of inheritance with 5 concrete animals.  OOP principles are being used by returning strings in the console to show the implementation and inheritance of methods and properties.

## Author: Deziree Teague 

## Zoo Diagram

![diagram](https://github.com/dezteague/ZOO/blob/master/ZooDiagram.png)

## Object-Oriented Programming Principles

1. INHERITANCE: enables the ability to pass on properties and methods of a class to its derived classes

Example: The methods and properties are passed down from the Animal Class to its derived classes: warm blooded and cold blooded.  

2. ABSTRACTION: a template for future classes that will be derived and instantiated.  There are two types:
* concrete- can be instantiated, the default 
* abstract- cannot be instantiated 

Example: Tiger, Bear, Owl, Orangutan, and Goldfish are concrete which means they are instantiated objects of a class.  However, all other classes cannont be instantiated.  

3. POLYMORPHISM: targets methods using concrete, abstract, and virtual.
* concrete- the default method type
* abstract- only exists in abstract classes and requires override in derived classes
* virtual- optional to override in derived classes

Example: Eat and sound are abstract methods that are later overridden in dervied classes by requirement. Legs is a virtual method that is overridden in concrete classes such as Owl, Tiger, and Bear. 

4. ENCAPSULATION: allow access control through access modifiers which can be private, public, or protected.
* public- all access
* private- only accessed by the class itself
* protected - access given to a class and its derived classes

Example: All animal properties and methods are public, so that derived classes have all access to them.


Collaborators: Ryna Truong and Xia Liu
