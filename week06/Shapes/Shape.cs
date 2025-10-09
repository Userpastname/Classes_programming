using System.Dynamic;

public class Shape
{
    string _color = "";
    double _area = 0;
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea() {
        return _area;
    }
}