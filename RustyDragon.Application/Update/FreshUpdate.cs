using RustyDragon.Application.Helper;
using RustyDragon.Common.Interface;
using RustyDragon.Common.Model;

namespace RustyDragon.Application.Update
{
    public class FreshUpdate : IUpdaters
    {
        public CheeseType CheeseType => CheeseType.Fresh;
        
        public Cheese Update(Cheese cheese)
        {
            cheese.Price *= 0.90;

            return PriceHelper.LimitPrice(cheese);
        }
    }
}
