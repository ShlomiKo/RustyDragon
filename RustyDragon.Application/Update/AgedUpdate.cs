using RustyDragon.Application.Helper;
using RustyDragon.Common.Interface;
using RustyDragon.Common.Model;

namespace RustyDragon.Application.Update
{
    public class AgedUpdate : IUpdaters
    {
        public CheeseType CheeseType => CheeseType.Aged;

        public Cheese Update(Cheese cheese)
        {
            cheese.Price *= 1.05;

            return PriceHelper.LimitPrice(cheese);
        }
    }
}
