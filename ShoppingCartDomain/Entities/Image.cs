using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDomain.Entities
{
    public class Image
    {
        public int ImageID { get; set; }
        public string ImageUrl { get; set; }
        public int ProductID { get; set; }

    }
}
