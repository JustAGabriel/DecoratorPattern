using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    interface ICoffeeBlend
    {
        string Name { get; }
        double Price { get; }

        double CalculatePrice();
    }
}
