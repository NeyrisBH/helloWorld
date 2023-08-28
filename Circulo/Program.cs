// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Bienvenido, calculemos círculos");
// Pi * radio*radio
var resultado = 0d;
var radio = 0d;

Console.WriteLine("Ingrese el valor del radio :");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * (radio * radio);
Console.WriteLine("El area del círculo es : " + resultado);