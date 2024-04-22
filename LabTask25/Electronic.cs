using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask25
{
    internal class Electronic : IProduct
    {
        public string Name { get; }
        decimal Price { get; set; }
        public int Quantity { get; set; }

        public Electronic(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public void ReduceStock(int reduceAmount)
        {
            Quantity -= reduceAmount;
            Price -= 20;
        }
    }
}
