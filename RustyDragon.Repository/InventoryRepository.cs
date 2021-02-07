using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RustyDragon.Common.Interface;
using RustyDragon.Common.Model;

namespace RustyDragon.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        public async Task<IEnumerable<Cheese>> GetInventoryAsync()
        {
            return await Task.FromResult(new List<Cheese>
            {
                new Cheese() { BestBeforeDate = DateTime.Now.AddDays(6), Name = "Roquefort", CheeseType = CheeseType.Aged, DaysToSell = 10, Price = 5},
                new Cheese() { BestBeforeDate = DateTime.Now.AddDays(6), Name = "Calcagno", CheeseType = CheeseType.Unique, DaysToSell = 10, Price = 12.55},
                new Cheese() { BestBeforeDate = DateTime.Now.AddDays(6), Name = "Queso Fresco", CheeseType = CheeseType.Fresh, DaysToSell = 10, Price = 20},
                new Cheese() { BestBeforeDate = DateTime.Now.AddDays(6), Name = "Dragon Mozzarella", CheeseType = CheeseType.Special, DaysToSell = 13, Price = 10},
                new Cheese() { BestBeforeDate = DateTime.Now.AddDays(6), Name = "Noam", CheeseType = CheeseType.Standard, DaysToSell = 10, Price = 15}
            });
        }
    }
}
