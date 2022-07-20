namespace FigureAreaApp;

public class Triangle : Figure
{
    private readonly int a;
    private readonly int b;
    private readonly int c;

    public Triangle(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double CalculateArea()
    {
        if (IsRightTriangle())
        {
            return CalculateAreaRightTriangle();
        }

        var semiPerimeter = CalculateSemiPerimeter();
        return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
    }

    private double CalculateAreaRightTriangle()
    {
        var hypotenuse = Math.Max(a, Math.Max(b, c));
        
        if (hypotenuse == a)
        {
            return (double)b * c / 2;
        }

        if (hypotenuse == b)
        {
            return (double)a * c / 2;
        }

        if (hypotenuse == c)
        {
            return (double)a * b / 2;
        }

        throw new InvalidOperationException();
    }

    private double CalculateSemiPerimeter() => (double)(a + b + c) / 2;

    private bool IsRightTriangle()
    {
        return a * a + b * b == c * c ||
               a * a + c * c == b * b ||
               c * c + b * b == a * a;
    }
}