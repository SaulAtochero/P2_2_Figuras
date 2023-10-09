using System.Drawing;

namespace P2_2_Figuras;

internal abstract class Figura
{
  protected Color _color;

  public abstract double GetArea();
  public abstract Color GetColor();
  public abstract void SetColor(Color color);
}