using System;
using Fruit;

namespace Fruit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple A1 = new Apple { name = "Apple1", price = 3 };
            Apple A2 = new Apple { name = "Apple2", price = 4 };
            Apple A3 = new Apple { name = "Apple3", price = 6 };

            Banana B1 = new Banana { name = "Banana1", price = 2.3 };
            Banana B2 = new Banana { name = "Banana2", price = 3.2 };
            Banana B3 = new Banana { name = "Banana3", price = 1.7 };

            Pineapple P1 = new Pineapple { name = "Pineapple1", price = 4.3 };
            Pineapple P2 = new Pineapple { name = "Pineapple2", price = 2.3 };
            Pineapple P3 = new Pineapple { name = "Pineapple3", price = 1.6 };

                Console.WriteLine(A1.SayName());
            Fruit[] fruits = new Fruit[] { A1, A2, A3, B1, B2, B3, P1, P2, P3 };

            double totalPrice = 0;
            // TODO: make a loop that adds the price of each fruit to the total price
            foreach (var fruit in fruits)
            {
                totalPrice += fruit.price;
            }


            Console.WriteLine(totalPrice);
        }
    }
}
