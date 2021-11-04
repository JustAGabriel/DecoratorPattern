using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class StrongBlendCoffee : ICoffeeBlend
    {
        public string Name { get ; set ; }
        public double Price { get; set; }

        public StrongBlendCoffee()
        {
            this.Name = "Coffee from a strong Blend";
            this.Price = 2.99;
        }

        public double CalculatePrice()
        {
            return this.Price;
        }
    }
}
