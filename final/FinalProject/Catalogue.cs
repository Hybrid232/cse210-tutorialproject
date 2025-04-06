public class Catalogue
{
   private List<Product> _allProducts = new List<Product>();
   private Cart _userCart;

   public Catalogue(Cart userCart)
   {
     _userCart = userCart;
   }

   public void AddProduct(Product product)
   {
        _allProducts.Add(product);
   }

   public List<Product> GetAllProducts()
   {
       return new List<Product>(_allProducts);
   }

    //All Products
    public void ShowAllProducts()
    {
       bool foundItem = false;
        Console.WriteLine("====Full Catalogue====");
        foreach (Product products in _allProducts)
        {
            Console.WriteLine($"{products.GetCategory()}\n{products.GetID()} - {products.GetName()} -- ${products.GetPrice()} \n{products.GetDescription()} \nStock Left: {products.GetStockQuantity()}\n");
            foundItem = true;
        }
        if (!foundItem)
        {
            Console.WriteLine("No product Found");
        }

        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter ID of product to order or 'BACK' to return to catalogue menu: ");
            string input = Console.ReadLine().ToUpper();

            if (input == "BACK")
            {
                return;
            }
            if (int.TryParse(input, out int productInput))
            {
                Product selectedProduct = null;
                foreach(Product p in _allProducts)
                {
                    if (p.GetID() == productInput)
                    {
                        selectedProduct = p;
                        break;
                    }
                }
                if (selectedProduct != null)
                {
                    _userCart.AddToCart(selectedProduct);
                    validInput = true;
                    
                }
                else
                {
                    Console.WriteLine("Product Not Found!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Write("INVALID INPUT! Enter a valid product ID or 'BACK' to Catalogue menu.");
            }

        }


        
    }

    //Category Products
    public void ShowCategoryProduct(string CATEGORY)
    {
        if (CATEGORY.ToUpper() == "BACK")
        {
            return;
        }
        bool foundItem = false;

        Console.WriteLine($"---{CATEGORY} Products---");

        foreach (Product p in _allProducts)
        {
            if(p.GetCategory().ToLower() == CATEGORY.ToLower())
            {
                Console.WriteLine($"{p.GetID()} - {p.GetName()} -- ${p.GetPrice()} \n{p.GetDescription()} \nStock Left: {p.GetStockQuantity()}\n");
                foundItem = true;

                if(p is Entertainment entertainmentProduct)
                {
                    Console.WriteLine($"Brand: {entertainmentProduct.GetBrand()}\nWarranty: {entertainmentProduct.GetWarrentyMonth()} months\n");
                }
                else if (p is Clothing clothingProduct)
                {
                    Console.WriteLine($"Size: {clothingProduct.GetSize()}\n Color: {clothingProduct.GetColor()}\n");
                }
            }
        }
        if (!foundItem)
        {
            Console.WriteLine("INVALID INPUT");
        }
    }


    //Selected Product
    public void ShowSelectedProduct(int ID)
    {
        Product selected = null;
        foreach (Product p in _allProducts)
        {
            if(p.GetID() == ID)
            {
                selected = p;
                break;
            }
        }

        if (selected != null)
        {
            Console.WriteLine($"{selected.GetID()} - {selected.GetName()} -- ${selected.GetPrice()} \n{selected.GetDescription()} \nStock Left: {selected.GetStockQuantity()}\n");
        }
        else
        {
            Console.WriteLine($"{ID}-- is not an avalible product. Please try again!");
        }
    }

}