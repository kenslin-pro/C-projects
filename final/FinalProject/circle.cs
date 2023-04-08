class Circle
{
  public double Radius { get; set; }
  public Circle(double radius)
  {

    Radius = radius;

  }

  public double AreaOfCircle()
  {
    return Math.PI * Math.Pow(Radius, 2);
  }
  public double PerimeterOfCircle()
  {
    return (Math.PI + Radius) * 2;
  }
}
