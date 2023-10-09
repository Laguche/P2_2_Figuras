using System.Drawing;
namespace git;
public class Circulo : Figura
{
   private double _radio;

   public Circulo(double radio,Color _color){
    _radio=radio;
    Color=_color;
    
   }
   public void SetRadio(double radio){
    _radio=radio;
    
   }
   
    public override double GetArea()
    {
        return Math.PI*(Math.Pow(_radio,2));
    }

    public override string ToString()
    {
        return $"El circulo tiene de radio:{_radio}";
    }

    
}
