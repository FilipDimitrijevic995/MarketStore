using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class Silver : Card, IUtil
    {
        readonly Discount s1 = new Discount(3.5, 300, double.MaxValue);

        public Silver(double turnover)
        {
            InitialDiscount = 2;
            Turnover = turnover;
        }

        public void Calculate(double purchaseValue)
        {
            double total = 0;
            double discount = 0;
            double discountRate = InitialDiscount;

            if (Turnover < 300)
            {
                total = purchaseValue * (1 - InitialDiscount / 100);
                discount = purchaseValue - total;
            }
            else
            {
                total = s1.DiscountRate;
                total = purchaseValue * (1 - s1.DiscountRate / 100);
                discount = purchaseValue - total;
                discountRate = s1.DiscountRate;
            }

            System.Console.WriteLine("Bronze:");
            System.Console.WriteLine("Data: turnover ${0}, purchase value: ${1}", Turnover, purchaseValue);
            System.Console.WriteLine();
            System.Console.WriteLine("Purchase value: $" + purchaseValue);
            System.Console.WriteLine("Discount rate: %" + discountRate);
            System.Console.WriteLine("Discount: $" + discount);
            System.Console.WriteLine("Total: $" + total);
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine();
        }
    }
}
