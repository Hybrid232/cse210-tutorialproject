public class Square : Shape
{
    private double _side;

    public Square(string shapeColor, double squareSide) : base(shapeColor)
    {
        _side = squareSide;
    }


    public double GetSquareSide()
    {
        return _side;
    }

    public void SetSquareSide(double squareSide)
    {
        _side = squareSide;
    }


    public override double GetArea()
    {
        return _side * _side;
    }
}