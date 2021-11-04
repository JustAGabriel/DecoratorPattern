using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class StandardCoffee : ICoffeeBlend
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public StandardCoffee()
        {
            this.Name = "Standard Coffee";
            this.Price = 1.99;
        }

        public double CalculatePrice()
        {
            return this.Price;
        }
    }
}
