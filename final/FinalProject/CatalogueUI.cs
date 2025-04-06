public class CatalogueUI
{
    private Catalogue _catalogue;
    private Cart _userCart;

    public CatalogueUI(Catalogue catalogue, Cart userCart)
    {
        _catalogue = catalogue;
        _userCart = userCart;
    }

    public void Run()
    {
        
        bool repeatCatalogue = true;

        while (repeatCatalogue)
        {
            Console.Clear();
            CatalogueMenu();
            string catalogueInput = Console.ReadLine().ToUpper();

            if (catalogueInput == "FULL CATALOGUE")
            {
                //Full List
                Console.Clear();
                _catalogue.ShowAllProducts();
                continue;
            }
            else if (catalogueInput == "BACK")
            {
                repeatCatalogue = false;
                Console.Clear();
                break;

            }
            bool validCategory = false;
            foreach (var category in new List<string> { "GROCERY", "ENTERTAINMENT", "CLOTHING" })
            {
                if (catalogueInput == category)
                {
                    validCategory = true;
                    break;
                }
            }
            if (!validCategory)
            {
                Console.Write("INVALID INPUT!");
                Console.ReadLine();
                continue;
            }


            Console.Clear();
            _catalogue.ShowCategoryProduct(catalogueInput);


            Console.Write("Enter ID of product to order or 'BACK' to return to catalogue menu: ");
            string addItemInput = Console.ReadLine().ToUpper();

            if (addItemInput == "BACK")
            {
                continue;
            }
            if (int.TryParse(addItemInput, out int productInput))
            {
                Product selectedProduct = null;
                foreach(Product p in _catalogue.GetAllProducts())
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
                   
                }
                else
                {
                    Console.WriteLine("Product Not Found!");
                    Thread.Sleep(3000);
                }

            }
            else
            {
                Console.Write("Invalid Input! Enter a product ID.");
                Thread.Sleep(3000);
            }

        }
    }



    public void CatalogueMenu()
    {
        
        Console.WriteLine("==== Catalogue Menu ====\n");
        Console.WriteLine("GROCERY | ENTERTAINMENT | CLOTHING");
        Console.WriteLine("FULL CATALOGUE");
        Console.WriteLine("<<< BACK\n");
        Console.Write("Select: ");
    }
}