// See https://aka.ms/new-console-template for more information
using ClassDemoExtentionMethod;
using PersonLib.model;

Console.WriteLine("Hello, World!");


Person p = new Person("peter", "roskilde", 1958);

Console.WriteLine(p);

Console.WriteLine("Alder = " + p.Age());



