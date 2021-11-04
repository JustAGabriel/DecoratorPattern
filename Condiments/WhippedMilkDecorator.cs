using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    class WhippedMilkDecorator : ICondimentDecorator
    {
        public ICoffeeBlend Coffee { get; private set; }

        public string Name { get; private set; }

        public double Price { get; private set; }

        public WhippedMilkDecorator(ICoffeeBlend coffee)
        {
            Coffee = coffee ?? throw new ArgumentNullException(nameof(coffee));
            Name = "Whipped Milk";
            Price = 0.99;
        }

        public double CalculatePrice()
        {
            return this.Price + this.Coffee.CalculatePrice();
        }
    }
}
