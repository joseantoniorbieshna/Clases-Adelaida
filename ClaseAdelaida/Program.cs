// See https://aka.ms/new-console-template for more information
using ClaseAdelaida.Models;

Bebida bebida = new Bebida("Fanta", 333);
Console.WriteLine("He bebido una " + bebida.Nombre + " que tenía " + bebida.Cantidad + " mililitros.");
Console.WriteLine("*************************");

Bebida bebida2 = new Cerveza();
Console.WriteLine("He bebido una " + bebida2.Nombre + " que tenía " + bebida2.Cantidad + " mililitros.");
Console.WriteLine("*************************");

Bebida bebida3 = new Cerveza(333);
Console.WriteLine("He bebido una " + bebida3.Nombre + " que tenía " + bebida3.Cantidad + " mililitros.");
Console.WriteLine("*************************");

Cerveza bebida4 = new Cerveza(333, "Aguila");
Console.WriteLine("He bebido una " + bebida4.Nombre + " que tenía " + bebida4.Cantidad + " mililitros.");
Console.WriteLine("*************************");