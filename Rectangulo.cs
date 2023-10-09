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
        public override Color GetColor()
        {
            return _color;
        }
        //setters
        public void setLargo(double largo)
        {
            _largo = largo;
        }
        public void setAncho(double ancho)
        {
            _ancho = ancho;
        }
        public override void SetColor(Color value)
        {
            _color = value;
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
