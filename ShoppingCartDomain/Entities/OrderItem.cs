using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDomain.Entities
{
    public class OrderItem
    {
        public int OrtherID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Quantily { get; set; }

    }
}
