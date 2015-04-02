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
    class Brand_ProductBLL
    {
     DBExecute _db;
     public Brand_ProductBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(Brand_Product brand_product)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[3];
           paras[0] = new SqlParameter("@ProductID",brand_product.ProductsID);
           paras[1] = new SqlParameter("@BrandID", brand_product.BrandID);
           paras[2] = new SqlParameter("@Note", brand_product.Note);

           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(Brand_Product brand_product)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[3];
           paras[0] = new SqlParameter("@ProductID", brand_product.ProductsID);
           paras[1] = new SqlParameter("@BrandID", brand_product.BrandID);
           paras[2] = new SqlParameter("@Note", brand_product.Note);

           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(Product product)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@ProductID", product.ProductID);
         
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}