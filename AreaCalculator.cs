
namespace phase1;

public class AreaCalculator()
{
    private const double Pi = Double.Pi;
    private double Height { get; }
    private double Width { get; }
    private double Radius { get; }
    
    public AreaCalculator(double height, double width, double radius) : this()
    {
        Height = height;
        Width = width;
        Radius = radius;
    }

    private double Rect()
    {
        return Height * Width;

    }

    public double Triangle()
    {
        return (Height * Width) / 2;
    }

    public double Ellipse()
    {
        return Pi * Radius * Radius;
    }

    public double Operation(string op)
    {
        double result = double.NaN;
        switch (op)
        {
            case "R":
                result = Rect();
                break;
            case "T":
                result = Triangle();
                break;
            case "E":
                result = Ellipse();
                break;
        }
        return result;
    }

    
}
