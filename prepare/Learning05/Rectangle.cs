public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string shapeColor, double recLength, double recWidth) : base(shapeColor)
    {
        _length = recLength;
        _width = recWidth;
    }

    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double recLength)
    {
        _length = recLength;
    }

    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double recWidth)
    {
        _width = recWidth;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}