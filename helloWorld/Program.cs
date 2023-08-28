// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Programar que calcula el área de un rectangulo.
double ladoA;
double ladoB;
double resultado;

Console.WriteLine("Calcula el área de un rectangulo");
Console.WriteLine("Ingresa el lado del lado A: ");
ladoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa el lado del lado B: ");
ladoB = Convert.ToDouble(Console.ReadLine());
resultado = ladoA * ladoB;
Console.WriteLine("El resultado es: " + resultado);