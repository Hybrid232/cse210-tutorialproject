public class Clothing : Product
{
    private string _size;
    private string _color;

    public Clothing(int ID, string NAME, double PRICE, string CATEGORY, string DESCRIPTION, int STOCK, string SIZE, string COLOR)
    : base (ID, NAME, PRICE, CATEGORY, DESCRIPTION, STOCK)
    {
        _size = SIZE;
        _color = COLOR;
    }
    public string GetSize()
    {
        return _size;
    }
    public string GetColor()
    {
        return _color;
    }
}