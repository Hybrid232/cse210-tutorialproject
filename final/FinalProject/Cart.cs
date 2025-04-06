using System.ComponentModel.Design;
using System.Net.Http.Headers;

public class Cart 
{
    private List<Product> _userCart = new List<Product>();
    private UserInformation _userInfo;

    public Cart(UserInformation userInfo)
    {
        _userInfo = userInfo;
    }

    public void AddToCart(Product product)
    {
        if (product.GetStockQuantity() > 0)
        {
            _userCart.Add(product);
            product.SetStockQuantity(product.GetStockQuantity() - 1);
            Console.WriteLine($"{product.GetName()} has been added to your cart!");
            Thread.Sleep(3000);
        }
        else
        {
            Console.WriteLine($"Ooh Sorry! We are completely out of {product.GetName()}!");
            Thread.Sleep(3000);
        }
    }
    public void RemoveFromCart()
    {
        Console.Write("Enter product ID of item you want to remove: ");
        string removeInput = Console.ReadLine();

        if (int.TryParse(removeInput, out int productID))
        {
            Product productToRemove = null;

            foreach (var product in _userCart)
            {
                if (product.GetID() == productID)
                {
                    productToRemove = product;
                    break;
                }
            }

            if (productToRemove != null)
            {
                _userCart.Remove(productToRemove);
                productToRemove.SetStockQuantity(productToRemove.GetStockQuantity() + 1);
                Console.WriteLine($"{productToRemove.GetName()} has been removed from your cart!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("That item is not found in your cart!");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("INVALID ID");
            Thread.Sleep(3000);
        }

    }

    public void ViewCart()
    {
        if(_userCart.Count() == 0)
        {
            Console.Clear();
            Console.WriteLine("OOPS! Your Cart Is Empty");
            Thread.Sleep(3000);
            return;
        }

        Console.Clear();
        Console.WriteLine("====Your Cart====\n");
        
        double userTotal = 0;

        foreach(Product p in _userCart)
        {
            Console.WriteLine($"ID: {p.GetID()} -- {p.GetName()}");
            Console.WriteLine($"PRICE: ${p.GetPrice():0.00}");
            userTotal += p.GetPrice();
        }
        Console.WriteLine("========================================");
        Console.WriteLine($"\nTotal: ${userTotal:0.00}");
        Console.WriteLine(">REMOVE ITEM");
        Console.WriteLine(">BACK");
        Console.Write("\nSelect: ");
        string viewInput = Console.ReadLine().ToUpper();

        if (viewInput == "REMOVE ITEM")
        {
            RemoveFromCart();
        }
        
        else if (viewInput == "BACK")
        {
            Console.WriteLine("Returning to Menu...");
            Thread.Sleep(2000);
            Console.Clear();
        }

        
    }

    
    public void PurchaseItems()
    {
       double userTotal = 0;

       if (_userCart.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Oh... Your cart is empty!");
            Thread.Sleep(2000);
            return;
        }

        Console.Clear();
        Console.WriteLine("==== Checkout ====");
        foreach(Product p in _userCart)
        {
            Console.WriteLine($"ID: {p.GetID()} -- {p.GetName()}");
            Console.WriteLine($"PRICE: ${p.GetPrice():0.00}");
            userTotal += p.GetPrice();
        }

        Console.WriteLine("====================================================");
        Console.WriteLine($"Total: ${userTotal:0.00}\n");
        Console.Write($"Would you like to proceed to purchase? (Y/N): ");

        string checkoutInput = Console.ReadLine().ToUpper();

        if (checkoutInput == "Y")
        {
            if (_userInfo.GetBalance() >= userTotal)
            {
                _userInfo.SubtractBalance(userTotal);

                if (_userInfo is PremiumUserInformation premium)
                {
                    premium.ApplyCashback(userTotal);
                }

                
                _userCart.Clear();
                Console.WriteLine("Thank you for your purchase!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Insufficent funds! You need more money in your account!");
                Thread.Sleep(3000);
                Console.Clear();
            }

        }
        else
        {
            Console.WriteLine("Returning to menu...");
            Thread.Sleep(3000);
            Console.Clear();
        }


    }

    public void ProcessPayment(double total)
    {
        Console.WriteLine("Processing Payment...");
        Thread.Sleep(2000);
        Console.WriteLine($"Your payment of ${total:0.00} was a success!");
    }
}