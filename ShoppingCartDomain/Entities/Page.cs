using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDomain.Entities
{
    public class Page
    {
        public int PageID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Content { get; set; }

    }
}
