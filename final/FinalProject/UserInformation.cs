public class UserInformation
{
    protected double _avalibleBalance;

    public UserInformation(double beginningBalance)
    {
        _avalibleBalance = beginningBalance;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Current Avalible Balance: ${_avalibleBalance:0.00}");
    }
    public double GetBalance()
    {
        return _avalibleBalance;
    }
    public void SubtractBalance(double amount)
    {
        _avalibleBalance -= amount;
    }
    public void AddFunds(double amount)
    {
        _avalibleBalance += amount;
    }

    public void ShowPersonalInfo(UserInformation user)
    {
        bool userInfoMenu = true;
        while (userInfoMenu)
        {
            Console.Clear();
            Console.WriteLine("==== Personal Information ====");
            user.DisplayInfo();
            Console.WriteLine("\nOptions:");
            Console.WriteLine(">Add Funds");
            Console.WriteLine(">BACK\n");
            Console.Write("Select: ");

            string infoInput = Console.ReadLine().ToUpper();

            if(infoInput == "ADD FUNDS")
            {
                Console.Write("Enter fund amount: $");
                if(double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                {
                    user.AddFunds(amount);
                    Console.WriteLine($"${amount:0.00} has beed added to your account");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("INVALID AMOUNT!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            else if (infoInput == "BACK")
            {
                Console.WriteLine("Returning to Menu...");
                userInfoMenu = false;
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("INVALID INPUT! TRY AGAIN!");
                Thread.Sleep(300);
                Console.Clear();
            }
        }
    }
}