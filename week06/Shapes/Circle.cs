using System.Drawing;

public class Circle : Shape
{
    double _radius = 0;



    public Circle(double radius)
    {
        _radius = radius;
    }

    public Circle()
    {
        
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}