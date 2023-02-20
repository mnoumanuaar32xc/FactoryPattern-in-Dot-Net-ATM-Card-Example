# FactoryPattern
The Factory Pattern is a creational design pattern used to create objects in a simple and consistent way. This pattern helps to abstract the object creation process, allowing the program to use objects without knowing how they are created or the implementation details. The Factory Pattern is often used in applications to create objects that have similar characteristics, such as cars or animals. The Factory Pattern also helps to reduce the complexity of creating objects, since it allows the program to create them without having to specify their exact type. The Factory Pattern is also useful when the code needs to be flexible and extendable, since it allows the program to create different types of objects without having to modify the existing code.

The Factory pattern is a creational pattern that simplifies object creation. You no need worry about the object creation you just need to supply an appropriate parameter and factory provide you a product as needed.
Creation object without exposing the instantiation the logic to client 
Referring the newly created object through a common interface.
-----------------------------------------------------------------------------------------------------------
# How to Use 

Define the Factory Pattern concept in .Net we are using an example of Debit Cards in console Application.

Let suppose when we have multiple debit cards which have different features so by ATM machine we just insert the debit Card and machine get the name of that card and by Factory pattern we instantiate the specific card class.



