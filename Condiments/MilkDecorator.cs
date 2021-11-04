using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    class MilkDecorator : ICondimentDecorator
    {
        public ICoffeeBlend Coffee { get; private set; }

        public string Name { get; private set; }

        public double Price { get; private set; }

        

        public MilkDecorator(ICoffeeBlend coffee)
        {
            Coffee = coffee ?? throw new ArgumentNullException(nameof(coffee));
            this.Name = "Milk";
            this.Price = 0.99;
    }

        public double CalculatePrice()
        {
            return this.Price + this.Coffee.CalculatePrice();
        }
    }
}
