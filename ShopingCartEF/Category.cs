//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopingCartEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<bool> IsPublished { get; set; }
        public string test { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
