using System;
using RustyDragon.Application.Helper;
using RustyDragon.Common.Interface;
using RustyDragon.Common.Model;

namespace RustyDragon.Application.Update
{
    public class StandardUpdate : IUpdaters
    {
        public CheeseType CheeseType => CheeseType.Standard;

        public Cheese Update(Cheese cheese)
        {
            if (DateTime.Now - cheese.BestBeforeDate > TimeSpan.Zero)
            {
                cheese.Price *= 0.95;
            }
            else
            {
                cheese.Price *= 0.90;
            }
            return PriceHelper.LimitPrice(cheese);
        }
    }
}
