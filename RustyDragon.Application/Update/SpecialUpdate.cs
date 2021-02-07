using RustyDragon.Application.Helper;
using RustyDragon.Common.Interface;
using RustyDragon.Common.Model;

namespace RustyDragon.Application.Update
{
    public class SpecialUpdate : IUpdaters
    {
        public CheeseType CheeseType => CheeseType.Special;

        public Cheese Update(Cheese cheese)
        {
            if (cheese.DaysToSell <= 5)
            {
                cheese.Price *= 1.10;
            }
            else if(cheese.DaysToSell <= 10)
            {
                cheese.Price *= 1.05;
            }

            return PriceHelper.LimitPrice(cheese);
        }
    }
}
