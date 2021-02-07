using RustyDragon.Common.Model;

namespace RustyDragon.Common.Interface
{
    public interface IUpdaters
    {
        CheeseType CheeseType { get; }

        Cheese Update(Cheese cheese);
    }
}
