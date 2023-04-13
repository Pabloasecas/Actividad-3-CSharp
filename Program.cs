// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, el siguiente programa le pedirá dos números para sumarlos, restarlos, multiplicarlos y dividirlos");
Console.WriteLine("Introduzca el primer número"); 
var primerNumero = Console.ReadLine();
int numero1 = int.Parse(primerNumero);
Console.WriteLine("Introduzca el segudno número"); 
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(segundoNumero); 
var suma = numero1 + numero2;
var resta = numero1 - numero2;
var producto = numero1 * numero2;
var division = numero1 / numero2;
Console.WriteLine("El resultado de sumar los números " + primerNumero + "y" + segundoNumero + " es: ");
