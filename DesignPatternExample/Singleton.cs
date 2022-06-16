using System;

namespace DesignPatternExample
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
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
        public Singleton()
        {
            counter++;
            Console.WriteLine("Instance no. " + counter);
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
