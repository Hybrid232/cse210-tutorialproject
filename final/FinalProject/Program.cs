using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void MainMenu()
    {   
        Console.WriteLine("\n==== Main Menu ====");
        Console.WriteLine(" Catalogue");
        Console.WriteLine(" View Shopping Cart");
        Console.WriteLine(" Checkout");
        Console.WriteLine(" Personal Information");
        Console.WriteLine(" Exit\n");
        Console.Write("Select: ");
    }
    
    static void Main(string[] args)
    {
        UserInformation userInfo = new PremiumUserInformation(100.00);
        Cart userCart = new Cart(userInfo);
        Catalogue fullCatalogue = new Catalogue(userCart);
        CatalogueUI catalogueUI = new CatalogueUI(fullCatalogue, userCart);
        //GROCERY ITEMS//
        fullCatalogue.AddProduct(new Product(121, "Happy Mark Cereal", 3.99, "GROCERY", "Yummy box of Mark's happy flakeo's! Have a taste!", 15));
        fullCatalogue.AddProduct(new Product(131, "Larry's Ground Beef", 7.99, "GROCERY", "Larry's all natural, 100% pure lean cow beef! Perfect for your tastebuds!", 7));
        fullCatalogue.AddProduct(new Product(141, "Corperal Lightning BooJoo Kaboom 12-Pack Soda", 6.99, "GROCERY", "Corperal Lightning's new soda flavor of citrus lime will kaboom in your mouth!", 3));
        fullCatalogue.AddProduct(new Product(151, "Tom's Oranges", 2.99, "GROCERY", "Tom's Oragnes are very tangy and delicious!", 24));

        //ENTERTAINMENT ITEMS//
        fullCatalogue.AddProduct(new Entertainment(11551, "Nootendoo Flip 3", 399.99, "ENTERTAINMENT", "Play the new hit gameing console with all your friends!", 3, "Nootendo", 24));
        fullCatalogue.AddProduct(new Entertainment(11552, "Business Laptop", 799.99, "ENTERTAINMENT", "All your business needs are found on this fancy laptop!", 5, "BusniessTime Co.", 12));
        fullCatalogue.AddProduct(new Entertainment(11553, "That's No Deer", 19.99, "ENTERTAINMENT", "A simple drive in the forest is interupted by somthing that hit your truck...", 7, "GlassTopHat Games", 5));
        fullCatalogue.AddProduct(new Entertainment(11554, "Plasma TV Screen", 99.99, "ENTERTAINMENT", "Very nice tv screen for all your fun", 50, "Super TV's", 48));

        //CLOTHING ITEMS//
        fullCatalogue.AddProduct(new Clothing(22731, "Great Graphic T-Shirt", 14.99, "CLOTHING", "Super great t-shirt for every day wear!", 18, "L", "Red"));
        fullCatalogue.AddProduct(new Clothing(22732, "Epic Hoodie", 29.99, "CLOTHING", "What an epic hoodie for you to wear!", 10, "XL", "Black"));
        fullCatalogue.AddProduct(new Clothing(22733, "Ripped Jeans", 7.99, "CLOTHING", "Wanna look like a punk? Got some cool ripped jeans for you!", 14, "M", "Blue"));
        fullCatalogue.AddProduct(new Clothing(22734, "Chill Beanie", 5.99, "CLOTHING", "Cold out? No problem! A chill beanie to the rescue!", 4, "L", "Gray"));



        bool repeat = true;

        Console.WriteLine("Welcome to ManyItemsMart!");
        Console.WriteLine("Great to have you here today!");

        while(repeat)
        {
            MainMenu();
            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "CATALOGUE")
            {
                catalogueUI.Run();
                
            }
            else if (userInput == "VIEW SHOPPING CART")
            {
                userCart.ViewCart();
                
            }
            else if (userInput == "CHECKOUT")
            {
                userCart.PurchaseItems();
            }
            else if (userInput == "PERSONAL INFORMATION")
            {
                userInfo.ShowPersonalInfo(userInfo);
            }
            else if (userInput == "EXIT")
            {
                repeat = false;

            }
            else
            {
                Console.Clear();
            }


        }
        
    }
}