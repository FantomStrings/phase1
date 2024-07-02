
namespace phase1;

public class AreaCalculator()
{
    private const double Pi = double.Pi;
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

    private double Triangle()
    {
        return (Height * Width) / 2;
    }

    private double Ellipse()
    {
        return Pi * Radius * Radius;
    }

    public double Operation(string op)
    {
        var result = op switch
        {
            "R" => Rect(),
            "T" => Triangle(),
            "E" => Ellipse(),
            _ => double.NaN
        };
        return result;
    }

    
}
