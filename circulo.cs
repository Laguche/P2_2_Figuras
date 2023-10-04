public class Circulo : Figura
{
    private double radio;

    public Circulo(Color color, double radio) : base(color)
    {
        this.radio = radio;
    }

    public double GetRadio()
    {
        return radio;
    }

    public void SetRadio(double radio)
    {
        this.radio = radio;
    }

    public override double GetArea()
    {
        return Math.PI * radio * radio;
    }

    public override string ToString()
    {
        return $"Círculo de color {GetColor()}, radio: {radio}, área: {GetArea()}";
    }
}
