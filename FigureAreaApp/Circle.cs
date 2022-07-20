namespace FigureAreaApp;

public class Circle : Figure
{
    private readonly int radius;
    private const double pi = 3.14;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.Pow(radius, 2) * pi;
    }
}