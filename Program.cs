public class Singleton
{
    int count = 0;
    private Singleton()
    {
        count++;
        Console.WriteLine("Total instance created " + count.ToString());
    }


    private static Singleton? instance;


    public static Singleton GetInstance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }


    public void DisplayMessage()
    {
        Console.WriteLine("I am a message");
    }
}


public class Program
{
    public static void Main()
    {
        Singleton singletonInstance1 = Singleton.GetInstance;
        singletonInstance1.DisplayMessage();


        Singleton singletonInstance2 = Singleton.GetInstance;
        singletonInstance2.DisplayMessage();
    }
}


//OUTPUT
//Total instance created 1
//I am a message
//I am a message