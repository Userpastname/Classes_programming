using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Circle circle = new Circle(2);
        circle.SetColor("white");
        Square square = new Square(3);
        square.SetColor("blue");
        Triangle triangle = new Triangle(4,5);
        triangle.SetColor("red");


        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(triangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}