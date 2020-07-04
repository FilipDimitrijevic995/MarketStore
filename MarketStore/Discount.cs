namespace MarketStore
{
    class Discount
    {
        public double DiscountRate { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double MaxRate { get; set; }

        public Discount(double discountRate, double min, double max)
        {
            DiscountRate = discountRate;
            Min = min;
            Max = max;
        }

        public Discount(double discountRate, double min, double max, double maxRate)
        {
            DiscountRate = discountRate;
            Min = min;
            Max = max;
            MaxRate = maxRate;
        }

    }
}
