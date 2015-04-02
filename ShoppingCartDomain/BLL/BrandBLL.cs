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
   public class BrandBLL
    {
        DBExecute _db;
       public BrandBLL()
       {
           _db = new SQLExecute();
       }
        public   int Insert(Brands brands)
       {
           string proc = "PROC_Brand_Insert";
           SqlParameter[] paras = new SqlParameter[2];
           paras[0] = new SqlParameter("@ImageUrl", brands.ImageUrl);
           paras[1] = new SqlParameter("@Name", brands.Name);
          
           return _db.Execute_Modify(proc, paras, CommandType.StoredProcedure);           
       }
    public   int Update(Brands brands)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[3];
           paras[0] = new SqlParameter("@BrandID", brands.BrandID);
           paras[1] = new SqlParameter("@ImgUrl", brands.ImageUrl);
           paras[2] = new SqlParameter("@Name", brands.Name);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(Brands brands)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@BrandID", brands.BrandID);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}