using System;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square("blue", 5);
        Shape rectangle = new Rectangle("green", 3, 4);
        Shape circle = new Circle("red", 7);

        List<Shape> shapes = new List<Shape>() {square, rectangle, circle};

        foreach (Shape s in shapes)
        {
            string name = s.GetType().Name;
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"{name} \ncolor: {color} \narea: {area}units^2 \n");
        }
    }
}