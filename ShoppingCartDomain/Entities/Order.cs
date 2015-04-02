using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDomain.Entities
{
    public class Order
    {
        public int OrtherID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime DateRicived { get; set; }
        public string ShippingMethod { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
        public double Amout { get; set; }

    }
}
