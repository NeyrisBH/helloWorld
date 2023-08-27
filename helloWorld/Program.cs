// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Programar que calcula el área de un rectangulo.
int ladoA;
int ladoB;
int resultado;

Console.WriteLine("Calcula el área de un rectangulo");
Console.WriteLine("Ingresa el lado del lado A: ");
ladoA = Convert.ToInt32(Console.ReadLine());
ladoB = Convert.ToInt32(Console.ReadLine());
resultado = ladoA * ladoB;
Console.WriteLine(resultado);