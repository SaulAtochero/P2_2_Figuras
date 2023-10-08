//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    // Creo el rectangulo
    Rectangulo rectangulo = new Rectangulo(Color.FromArgb(255, 50, 20, 34), 3, 3.9);
    Console.WriteLine(rectangulo.ToString());
    Console.WriteLine($"Area: {rectangulo.GetArea()} ");

    // Modifico el largo y ancho del rectangulo
    rectangulo.setLargo(4);
    rectangulo.setAncho(5);
    Console.WriteLine(rectangulo.ToString() + "\n_____________________________________________________________________");

    // Creo el circulo
    Circulo circulo = new Circulo(Color.FromArgb(255, 50, 20, 34), 3);
    Console.WriteLine(circulo.ToString());
    Console.WriteLine($"Area: {circulo.GetArea()}");

    // Modifico el radio del circulo
    circulo.setRadio(4);
    Console.WriteLine(circulo.ToString() + "\n_____________________________________________________________________");

    // Creo el triangulo
    Triangulo triangulo = new Triangulo(Color.FromArgb(255, 50, 20, 34), 3);
    Console.WriteLine(triangulo.ToString());
    Console.WriteLine($"Area: {triangulo.GetArea()}");

    // Modifico el parametro del triangulo 
    triangulo.setLado(4);
    Console.WriteLine(triangulo.ToString() + "\n_____________________________________________________________________");

  }

}