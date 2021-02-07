using System;
using System.Collections.Generic;
using System.Linq;
using RustyDragon.Common.Interface;
using RustyDragon.Common.Model;

namespace RustyDragon.Application.Update
{
    public class UpdateStrategy : IUpdateStrategy
    {
        private readonly IEnumerable<IUpdaters> _updaters;

        public UpdateStrategy(IEnumerable<IUpdaters> updaters)
        {
            _updaters = updaters;
        }

        public Cheese Update(Cheese cheese, CheeseType type)
        {
            return _updaters.FirstOrDefault(x => x.CheeseType == type)?.Update(cheese) ?? throw new ArgumentNullException(nameof(type));
        }
    }
}
