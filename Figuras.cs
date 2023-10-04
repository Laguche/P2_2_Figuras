namespace git;

public abstract class Figura
{
    private Color color;

    public Figura(Color color)
    {
        this.color = color;
    }

    public Color GetColor()
    {
        return color;
    }

    public void SetColor(Color color)
    {
        this.color = color;
    }

    public abstract double GetArea();

    public override string ToString()
    {
        return $"Figura de color {color}";
    }
}