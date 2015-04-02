using ShoppingCartDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataProvider;
using System.Data.SqlClient;


namespace ShoppingCartDomain.BLL
{
   public  class ProductBLL
    {
       DBExecute _db;
       public ProductBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(Product product)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[12];
           paras[0] = new SqlParameter("@ProductID",product.ProductID);
           paras[1] = new SqlParameter("@CategoryID", product.CategoryID);
           paras[2] = new SqlParameter("@BrandID", product.BrandID);
           paras[3] = new SqlParameter("@ImgUrl", product.ImageUrl);
           paras[4] = new SqlParameter("@Name", product.Name);
           paras[5]= new SqlParameter("@Description", product.Description);
           paras[6] = new SqlParameter("@Price", product.Price);
           paras[7] = new SqlParameter("@SalePrice", product.SalePrice);
           paras[8] = new SqlParameter("@DateCreated", product.DateCreated);
           paras[9] = new SqlParameter("@Detail", product.Detail);
           paras[10] = new SqlParameter("@SortOder", product.SortOder);
           paras[11] = new SqlParameter("@IsPublished", product.IsPublished);

           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(Product product)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[9];
           paras[0] = new SqlParameter("@ImgUrl", product.ImageUrl);
           paras[1] = new SqlParameter("@Name", product.Name);
           paras[2] = new SqlParameter("@Description", product.Description);
           paras[3] = new SqlParameter("@Price", product.Price);
           paras[4] = new SqlParameter("@SalePrice", product.SalePrice);
           paras[5] = new SqlParameter("@DateCreated", product.DateCreated);
           paras[6] = new SqlParameter("@Detail", product.Detail);
           paras[7] = new SqlParameter("@SortOder", product.SortOder);
           paras[8] = new SqlParameter("@IsPublished", product.IsPublished);

           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(int productID)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@ProductID", productID);
         
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}