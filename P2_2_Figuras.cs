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
    Console.WriteLine(triangulo.ToString() + "\n_____________________________________________________________________\n\n\n\n");

    //Creo lista de figuras
    List<Figura> lista = new List<Figura>();
    //Creacion de 6 figuras
    Rectangulo rec1 = new Rectangulo(Color.FromArgb(255, 50, 20, 34), 3, 3.9);
    Rectangulo rec2 = new Rectangulo(Color.FromArgb(255, 60, 30, 44), 4, 4.9);
    Circulo cir1 = new Circulo(Color.FromArgb(255, 50, 20, 34), 3);
    Circulo cir2 = new Circulo(Color.FromArgb(255, 60, 30, 44), 4);
    Triangulo tri1 = new Triangulo(Color.FromArgb(255, 50, 20, 34), 3);
    Triangulo tri2 = new Triangulo(Color.FromArgb(255, 60, 30, 44), 4);
    //Añado las instancias a la lista creada anteriormente
    lista.Add(rec1);
    lista.Add(rec2);
    lista.Add(cir2);
    lista.Add(cir1);
    lista.Add(tri1);
    lista.Add(tri2);
    //Recorro la lista
    foreach (Figura f in lista)
    {
      Console.WriteLine(f.ToString() + " Area: " + f.GetArea());
    }
    //Recorro la lista, pero cambiando el color a todas la figuras
    foreach (Figura f in lista)
    {
      f.SetColor(Color.FromArgb(245, 40, 145, 200));
      Console.WriteLine(f.ToString() + " Area: " + f.GetArea());
    }
    //Recorrer una lista e ir sumando las areas de todas las figuras
    Double area = 0;
    foreach (Figura f in lista)
    {
      area += f.GetArea();
    }
    Console.WriteLine("El area total de todas las figuras es: " + area);
  }

}