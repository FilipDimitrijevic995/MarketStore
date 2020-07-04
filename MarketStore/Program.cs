using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Bronze bronze = new Bronze(0);
            bronze.Calculate(150);

            Silver silver = new Silver(600);
            silver.Calculate(850);

            Gold gold = new Gold(1500);
            gold.Calculate(1300);

            Console.ReadKey();
        }
        
    }
}
