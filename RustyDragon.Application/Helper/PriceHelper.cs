using RustyDragon.Common.Model;

namespace RustyDragon.Application.Helper
{
    public static class PriceHelper
    {
        private const double MinPrice = 0;
        private const double MaxPrice = 20;

        public static Cheese LimitPrice(Cheese cheese)
        {
            if (cheese.Price < MinPrice)
            {
                cheese.Price = MinPrice;
            }

            if (cheese.Price > MaxPrice)
            {
                cheese.Price = MaxPrice;
                
            }
            return cheese;
        }
    }
}
