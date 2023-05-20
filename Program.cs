public interface SubscriptionPla
{
    public void DisplaySelectedPlan();
}


public class PlatinumPlan : SubscriptionPlan
{
    public void DisplaySelectedPlan()
    {
        Console.WriteLine("Platinum plan is selected");
    }
}


public class DiamondPlan : SubscriptionPlan
{
    public void DisplaySelectedPlan()
    {
        Console.WriteLine("Diamond plan is selected");
    }
}


public class GoldenPlan : SubscriptionPlan
{
    public void DisplaySelectedPlan()
    {
        Console.WriteLine("Golden plan is selected");
    }
}


public class SubscriptionPlanFactory
{
    public static SubscriptionPlan SelectPlan(string type)
    {
        switch (type)
        {
            case "patinum":
                return new PlatinumPlan();
            case "diamond":
                return new DiamondPlan();
            case "golden":
                return new GoldenPlan();
            default:
                throw new ArgumentException("Invalid plan type.");
        }
    }
}


public class Program
{
    public static void Main()
    {
        SubscriptionPlan subscription = SubscriptionPlanFactory.SelectPlan("patinum");
        subscription.DisplaySelectedPlan();
    }
}