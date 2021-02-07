using RustyDragon.Common.Model;

namespace RustyDragon.Common.Interface
{
    public interface IUpdateStrategy
    {
        Cheese Update(Cheese cheese, CheeseType type);
    }
}
