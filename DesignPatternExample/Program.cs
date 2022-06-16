using System;

namespace DesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance;
            singleton1.PrintMessage("Message from Singleton 1");

            Singleton singleton2 = Singleton.GetInstance;
            singleton2.PrintMessage("Message from Singleton 2");
        }
    }
}
