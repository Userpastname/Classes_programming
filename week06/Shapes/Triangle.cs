public class Triangle : Shape
{
    double _length = 0;
    double _width = 0;

    public Triangle(double length, double width)
    {
        _length = length;
        _width = width;
    }
    public Triangle()
    {

    }
    public override double GetArea()
    {
        return (_length * _width) / 2;
    }
    
    
}