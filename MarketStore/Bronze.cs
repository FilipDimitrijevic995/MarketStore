namespace MarketStore
{
    class Bronze : Card, IUtil
    {
        readonly Discount b1 = new Discount(1, 100, 300);
        readonly Discount b2 = new Discount(2.5, 300, double.MaxValue);

        public Bronze(double turnover)
        {
            InitialDiscount = 0;
            Turnover = turnover;
        }

        public void Calculate(double purchaseValue)
        {
            double total = 0;
            double discount = 0;
            double discountRate = InitialDiscount;

            if (Turnover < 100)
            {
                total = purchaseValue;
            }
            else if (Turnover > 100 && Turnover < 300)
            {
                total = purchaseValue * (1 - b1.DiscountRate / 100);
                discount = purchaseValue - total;
                discountRate = b1.DiscountRate;
            }
            else
            {
                total = purchaseValue * (1 - b2.DiscountRate / 100);
                discount = purchaseValue - total;
                discountRate = b2.DiscountRate;
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
