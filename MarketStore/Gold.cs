using System;

namespace MarketStore
{
    public class Gold : Card, IUtil
    {
        readonly Discount g1 = new Discount(1, 100, 100, 10);

        public Gold(double turnover)
        {
            InitialDiscount = 2;
            Turnover = turnover;
        }

        public void Calculate(double purchaseValue)
        {
            int limit = 0;
            int increment = (int)Math.Floor(Turnover / 100);

            if (increment > 8)
                limit = 8;
            else
                limit = increment;

            for (int i = 0; i < limit; i++)
            {
                InitialDiscount += g1.DiscountRate;
            }

            double total = 0;
            total = purchaseValue * (1 - InitialDiscount / 100);
            double discount = purchaseValue - total;

            Console.WriteLine("Gold:");
            Console.WriteLine("Data: turnover ${0}, purchase value: ${1}", Turnover, purchaseValue);
            Console.WriteLine();
            Console.WriteLine("Purchase value: $" + purchaseValue);
            Console.WriteLine("Discount rate: %" + InitialDiscount);
            Console.WriteLine("Discount: $" + discount);
            Console.WriteLine("Total: $" + total);
            Console.WriteLine("-----------------");
        }
    }
}
