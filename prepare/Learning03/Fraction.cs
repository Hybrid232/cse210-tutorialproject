

public class Fraction 
{
    private int _topNum;
    private int _bottomNum;
   

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public void SetTop(int topWhole)
    {
        _topNum = topWhole;
        _bottomNum = 1;
    }

    public void SetBothFraction(int topNum, int bottomNum)
    {
        _topNum = topNum;
        _bottomNum = bottomNum;
    }

    public string GetFractionString()
    {
        string numbers = $"{_topNum}/{_bottomNum}";
        return numbers;
    }

    public double GetFractionFloat()
    {
        
        return (double)_topNum / (double)_bottomNum;
    }


}