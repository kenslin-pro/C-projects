using System;

class Program
{
  static void Main(string[] args)
  {
    Rectangle rectangle = new Rectangle(4, 5);
    Console.WriteLine(rectangle.AreaOfRectangle());
    Console.WriteLine(rectangle.PerimeterOfRectangle());

    Square square = new Square(5);
    Console.WriteLine(square.AreaOfRectangle());
    Console.WriteLine(square.PerimeterOfRectangle);

    Circle circle = new Circle(14);
    Console.WriteLine(circle.AreaOfCircle());
    Console.WriteLine(circle.PerimeterOfCircle());

  }
}