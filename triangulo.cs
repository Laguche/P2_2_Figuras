using System.Drawing;
namespace git;

public class TrianguloEquilatero : Figura
{
  private double _lado;
  

  public TrianguloEquilatero(double lado,Color _color){
    _lado=lado;
    Color=_color;
  }
  
  public void SetLado(double lado){
    _lado=lado;
  }
  
    
    public override double GetArea()
    {
        return Math.Sqrt(3)*_lado*_lado/4;
    }

    public override string ToString()
    {
        return $"El trinagulo tiene un lado de : {_lado}";
    }
}