using DecoratorPattern.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffeeBlend coffeeWithMik = new MilkDecorator(new StrongBlendCoffee());
            string result = nameof(coffeeWithMik) + " costs : " + coffeeWithMik.CalculatePrice();
            Console.WriteLine(result);

            ICoffeeBlend coffeeWithWhippedMilk = new WhippedMilkDecorator(new StandardCoffee());
            string result2 = nameof(coffeeWithWhippedMilk) + " costs : " + coffeeWithWhippedMilk.CalculatePrice();
            Console.WriteLine(result2);
        }
    }
}
