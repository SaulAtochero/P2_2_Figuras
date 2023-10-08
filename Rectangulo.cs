using System.Drawing;

namespace P2_2_Figuras
{
    internal class Rectangulo : Figura
    {
        private double _largo;
        private double _ancho;

        public Rectangulo(Color color, double largo, double ancho)
        {
            _color = color;
            _largo = largo;
            _ancho = ancho;
        }
        //getters
        public double getLargo()
        {
            return _largo;
        }
        public double getAncho()
        {
            return _ancho;
        }
        //setters
        public void setLargo(double value)
        {
            _largo = value;
        }
        public void setAncho(double value)
        {
            _ancho = value;
        }

        public override double GetArea()
        {
            return getLargo() * getAncho();
        }
        public override string ToString()
        {
            return $"FIGURA RECTANGULO Alto:{getLargo()} Ancho:{getAncho()} Color: {_color}";
        }
    }
}
