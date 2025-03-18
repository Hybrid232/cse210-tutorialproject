using System.Globalization;

public class Shape 
{
    private string _color;

    public Shape(string shapeColor)
    {
        _color = shapeColor;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string shapeColor)
    {
        _color = shapeColor;
    }

    public virtual double GetArea()
    {
        return -1;
    }
}