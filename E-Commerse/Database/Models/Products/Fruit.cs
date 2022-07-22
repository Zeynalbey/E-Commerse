using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerse.Database.Models.Products
{
    class Fruit:Product
    {
        public Fruit(string name, decimal price, bool isProductFinished)
        :base(name,price,isProductFinished)
        {
            
        }
    }
}
