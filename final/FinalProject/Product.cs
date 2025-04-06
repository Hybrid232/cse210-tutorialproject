using System.Data;

 public class Product
{
    private int _id;
    private string _name;
    private double _price;
    private string _category;
    private string _description;
    private int _stockQuant;

    public Product(int ID, string NAME, double PRICE, string CATEGORY, string DESCRIPTION, int STOCK)
    {
        _id = ID;
        _name = NAME;
        _price = PRICE;
        _category = CATEGORY;
        _description = DESCRIPTION;
        _stockQuant = STOCK;
    }

    public int GetID()
    {
        return _id;
    }
    public string GetName()
    {
        return _name;
    }
    public double GetPrice()
    {
        return _price;
    }
    public string GetCategory()
    {
        return _category;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetStockQuantity()
    {
        return _stockQuant;
    }
    public void SetStockQuantity(int newQuant)
    {
        _stockQuant = newQuant;
    }

}




































//     private List<string> _produce = new List<string>();
//     private List<string> _grocery = new List<string>();
//     private List<string> _homeEssentials = new List<string>();
//     private List<string> _personalCare = new List<string>();
//     private List<string> _electronicsAndFun = new List<string>();

    

//     public void GetProduce()
//     {
//         _produce.Add("Bundle of Apples");
//         _produce.Add("Bundle of Banannas");
//         _produce.Add("Pack of Carrots");
//         _produce.Add("Head of Lettuce");
        
//         // Random ran = new Random();
//         // for (int i = 0; i < _produce.Count(); ++i)
//         // {
//         //     double price = (double)(ran.NextDouble() * (3.99 - 1.99) + 1.99);
//         //     Console.Write($"{i + 1}. ");
//         //     Console.WriteLine($"{_produce[i]} -- ${price:F2}");
//         // }

        
//     }
//     public void GetGrocery()
//     {
//         _grocery.Add("Box of Cereal -- $3.99");
//         _grocery.Add("Taco Seasoning Pack -- $0.99");
//         _grocery.Add("Beef -- $6.99");
//         _grocery.Add("Chicken -- $4.99");
//         _grocery.Add("12-Pack of Soda -- $7.99");
//     }
//     public void GetHomeEssentials()
//     {
//         _homeEssentials.Add("Table Lamp -- $10.99");
//         _homeEssentials.Add("Frying Pan -- $6.99");
//         _homeEssentials.Add("Bed Frame -- $34.99");
//         _homeEssentials.Add("Pack of Forks -- $2.99");
//         _homeEssentials.Add("Air Fryer -- $24.99");
//     }
//     public void GetPersonalCare()
//     {
//         _personalCare.Add("Shampoo -- $5.99");
//         _personalCare.Add("Bar Soap -- $4.99");
//         _personalCare.Add("Conditioner -- $5.99");
//         _personalCare.Add("Cologne -- $19.99");
//         _personalCare.Add("Perfume -- $25.99");
//     }
//     public void GetElectronicsAndFun()
//     {
//         _electronicsAndFun.Add("HD-Television -- $999.99");
//         _electronicsAndFun.Add("Hit Game Console -- $399.99");
//         _electronicsAndFun.Add("New Hype Movie -- $20.99");
//         _electronicsAndFun.Add("Super Cool Video Game -- $59.99");
//         _electronicsAndFun.Add("Bluetooth Speaker -- $49.99");
//     }