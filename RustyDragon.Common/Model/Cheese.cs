using System;

namespace RustyDragon.Common.Model
{
    public class Cheese
    {
        public string Name { get; set; }
        public DateTime BestBeforeDate { get; set; }
        public int DaysToSell { get; set; }
        public double Price { get; set; }
        public CheeseType CheeseType { get; set; } = CheeseType.Standard;
    }
}
