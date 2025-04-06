public class PremiumUserInformation : UserInformation
{
    private double _cashBackRate = 0.05;

    public PremiumUserInformation(double beginningBalance) : base(beginningBalance)
    {

    }
    
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Cashback Rate: {_cashBackRate * 100}%");
    }

    public void ApplyCashback(double purchaseAmount)
    {
        double cashback = purchaseAmount * _cashBackRate;
        AddFunds(cashback);
        Console.WriteLine($"Cashback Applied: ${cashback:0.00}");
    }
}