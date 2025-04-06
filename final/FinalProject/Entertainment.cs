public class Entertainment : Product
{
    private string _brand;
    private int _warrentyMonths;

    public Entertainment(int ID, string NAME, double PRICE, string CATEGORY, string DESCRIPTION, int STOCK, string BRAND, int WARRENTY)
    : base (ID, NAME, PRICE, CATEGORY, DESCRIPTION, STOCK)
    {
        _brand = BRAND;
        _warrentyMonths = WARRENTY;
    }
    public string GetBrand()
    {
        return _brand;
    }
    public int GetWarrentyMonth()
    {
        return _warrentyMonths;
    }
    public void SetWarrentyMonth(int value)
    {
        _warrentyMonths = value;
    }
}