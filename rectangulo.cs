using System.Drawing;
namespace git;
public class Rectangulo : Figura
{
   private double _altura;
   private double _base;

    

    public Rectangulo(double altura,double bases){
        _altura=altura;
        _base=bases;
   }
   public void SetDimensiones(double altura, double bases)
    {
        _altura = altura;
        _base = bases;
    }
   
    public override double GetArea()
    {
        return _altura*_base;
    }
    public override string ToString()
    {
        return $"El Rectangulo es de altura: {_altura} y de base: {_base}";
    }

}