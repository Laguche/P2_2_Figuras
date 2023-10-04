namespace git;
public class Rectangulo : Figura
{
    private double baseRectangulo;
    private double alturaRectangulo;

    public Rectangulo(Color color, double baseRectangulo, double alturaRectangulo) : base(color)
    {
        this.baseRectangulo = baseRectangulo;
        this.alturaRectangulo = alturaRectangulo;
    }

    public double GetBase()
    {
        return baseRectangulo;
    }

    public void SetBase(double baseRectangulo)
    {
        this.baseRectangulo = baseRectangulo;
    }

    public double GetAltura()
    {
        return alturaRectangulo;
    }

    public void SetAltura(double alturaRectangulo)
    {
        this.alturaRectangulo = alturaRectangulo;
    }

    public override double GetArea()
    {
        return baseRectangulo * alturaRectangulo;
    }

    public override string ToString()
    {
        return $"Rectángulo de color {GetColor()}, base: {baseRectangulo}, altura: {alturaRectangulo}, área: {GetArea()}";
    }
}