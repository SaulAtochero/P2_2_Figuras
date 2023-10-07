using System.Drawing;

namespace P2_2_Figuras
{
    internal class Triangulo : Figura
    {
        private double _lado;

        public Triangulo(Color color, double lado)
        {
            _color = color;
            setLado(lado);
        }

        //getter
        public double getLado()
        {
            return _lado;
        }

        //setter
        public void setLado(double value)
        {
            _lado = value;
        }

        public override double GetArea()
        {
            return (System.Math.Sqrt(3) / 4) * System.Math.Pow(getLado(), 2);
        }
        public override string ToString()
        {
            return $"FIGURA TRIANGULO Lado:{getLado()} Color: {_color}";
        }
    }
}
