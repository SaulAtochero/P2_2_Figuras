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
            Largo = largo;
            Ancho = ancho;
        }
        //getters
        public double getLargo
        {
            return _largo;
        }
        public double getAncho
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
            return getLargo * getAncho;
        }
    }
}
