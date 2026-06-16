# C# Projects

These are small projects I built using C# and the .NET Framework/.NET platform.

## Projects

- [Car Insurance](./CarInsurance)
- [Console App Assignment 1](./ConsoleApp_Assignment_1)
- [Math Parameter Console App](./MathParameterConsoleApp)
- [Operator Overload](./EmployeeOperatorOverload)
- [Polymorphism Assignment](./Polymorphism_Assignment)
- [Student Database Console App](./StudentDatabase_ConsoleApp)

## Car Insurance

This project is an ASP.NET MVC web application that mimics a car insurance quote website. It accepts user policy information, stores insuree records with Entity Framework Core, and calculates a quote using business rules based on age, vehicle year, vehicle make and model, speeding tickets, DUI history, and coverage type. It also includes an admin page where staff can view submitted quotes.

## Console App Assignment 1

This console application demonstrates boolean comparisons with loop control. It uses a `while` loop and a `do while` loop to show how conditions are evaluated and how counters can be used to determine when a loop should continue or stop.

## Math Parameter Console App

This console application demonstrates creating a class with a method that accepts two integer parameters. The method performs a math operation on the first number, displays the result, and also displays the second number. The program calls the method both with positional arguments and with named parameters.

## Operator Overload

This project demonstrates operator overloading in C#. It defines an `Employee` class and overloads the `==` and `!=` operators so two employee objects can be compared by their `Id` values. It also overrides `Equals()` and `GetHashCode()` to keep equality behavior consistent.

## Polymorphism Assignment

This console application demonstrates object-oriented programming concepts including abstraction, inheritance, interfaces, and polymorphism. It defines an abstract `Person` class, an `Employee` class, and an `IQuittable` interface, then uses an interface reference to call the employee's `Quit()` behavior.

## Student Database Console App

This console application demonstrates a basic Entity Framework database workflow. It defines `Student` and `Grade` entity classes, a `SchoolContext` database context, and inserts a student record into the database using Entity Framework.
