// See https://aka.ms/new-console-template for more information
using ClassDemoExtentionMethod;
using PersonLib.model;

Console.WriteLine("Hello, World!");


Person p = new Person("peter", "roskilde", 1958);

Console.WriteLine(p);

Console.WriteLine("Alder = " + p.Age());

Point start = new Point(8, 3);
Point end = new Point(9, 15);

Console.WriteLine(start);
Console.WriteLine(end);

Point nyPunkt = start + end;
Console.WriteLine(nyPunkt);




