using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerse.Database.Models.Products
{
    public class Food:Product
    {
        public Food(string name, decimal price, bool isProductFinished)
            : base(name, price, isProductFinished)
        {

        }
    }
}
