using RustyDragon.Common.Interface;
using RustyDragon.Common.Model;

namespace RustyDragon.Application.Update
{
    public class UniqueUpdate : IUpdaters
    {
        public CheeseType CheeseType => CheeseType.Unique;

        public Cheese Update(Cheese cheese)
        {
            return cheese;
        }
    }
}
