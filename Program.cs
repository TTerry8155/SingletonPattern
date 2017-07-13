using System;

namespace SingletonPattern.cs
{
    class Program
    {
        static void Main(string[] args)
        {

           
            LedgerSingleton s1 = LedgerSingleton.Instance;
            LedgerSingleton s2 = LedgerSingleton.Instance;

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}