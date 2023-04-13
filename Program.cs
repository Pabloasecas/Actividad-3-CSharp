// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, el siguiente programa le pedirá dos números para sumarlos, restarlos, multiplicarlos y dividirlos");
Console.WriteLine("Introduzca el primer número"); 
var primerNumero = Console.ReadLine();
Console.WriteLine("Introduzca el segudno número"); 
var segundoNumero = Console.ReadLine();
Console.WriteLine("El resultado de sumar los números " + primerNumero + "y" + segundoNumero + " es: " + Sumar() );
