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
        public override Color GetColor()
        {
            return _color;
        }

        //setter
        public void setRadio(double radio)
        {
            _radio = radio;
        }
        public override void SetColor(Color color)
        {
            _color = color;
        }

        public override double GetArea()
        {
            return System.Math.PI * System.Math.Pow(getRadio(), 2);
        }
        public override string ToString()
        {
            return $"FIGURA CIRCULO Radio:{getRadio()} Color: {_color}";
        }
    }
}
