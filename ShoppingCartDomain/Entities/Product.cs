using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDomain.Entities
{
    class Product
    {
        // khong can mau me dau
        public  int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public float SalePrice { get; set; }
        public string Detail { get; set; }
        public int SortOder { get; set; }
        public bool IsPublished { get; set; }
        public DateTime DateCreated { get; set; }


    }
}
