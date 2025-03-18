public class Circle : Shape 
{
    private double _radius;

    public Circle(string shapeColor, double circRadius) : base(shapeColor)
    {
        _radius = circRadius;
    }

    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double circRadius)
    {
        _radius = circRadius;
    }

    public override double GetArea()
    {
        return 3.14159 * (_radius * _radius);
    }
}   