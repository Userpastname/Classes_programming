public class Square : Shape
{
    double _side = 0;

    public Square(double side){
        _side = side;
    }
    public Square(){

    }
    public override double GetArea()
    {
        return Math.Pow(_side, 2);
    }
}