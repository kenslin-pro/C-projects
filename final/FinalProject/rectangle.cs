
class Rectangle
{
  public double Length { get; set; }
  public double Width { get; set; }
  public Rectangle(double length, double width)
  {
    Length = length;
    Width = width;
  }

  public double AreaOfRectangle()
  {
    return Length * Width;
  }
  public double PerimeterOfRectangle()
  {
    return (Length + Width) * 2;
  }
}