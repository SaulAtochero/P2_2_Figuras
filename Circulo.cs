using System.Drawing;

namespace P2_2_Figuras
{
    internal class Circulo : Figura
    {
        private double _radio;

        public Circulo(Color color, double radio)
        {
            _color = color;
            setRadio(radio);
        }

        //getter
        public double getRadio()
        {
            return _radio;
        }

        //setter
        public void setRadio(double value)
        {
            _radio = value;
        }

        public override double GetArea()
        {
            return System.Math.PI * System.Math.Pow(getRadio(), 2);
        }
    }
}
