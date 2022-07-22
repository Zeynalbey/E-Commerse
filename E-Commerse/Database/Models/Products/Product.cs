using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerse.Database.Models.Products
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsProductFinished { get; set; }

        public Product(string name, decimal price, bool isProductFinished)
        {
            Name = name;
            Price = price;
            IsProductFinished = isProductFinished;

        }

    }
}
