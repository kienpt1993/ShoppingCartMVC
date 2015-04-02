using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDomain.Entities
{
    public class News
    {
        public int NewsID { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public int Hits { get; set; }

    }
}
