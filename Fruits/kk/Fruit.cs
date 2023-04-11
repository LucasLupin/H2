using System;
using System.Xml.Linq;

namespace Fruit
{
    internal class Fruit
    {
        public string name { get; set; }
        public double price { get; set; }

        public string SayName()
        {
            return name;
        }
    }

}
