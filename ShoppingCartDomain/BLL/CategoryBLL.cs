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
   public  class CategoryBLL
    {
       DBExecute _db;
       public CategoryBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(Category category)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[8];
           paras[0] = new SqlParameter("@CategoryID", category.CategoryID);
           paras[1] = new SqlParameter("@Name", category.Name);
           paras[2] = new SqlParameter("@ImageUrl", category.ImageUrl);
           paras[3] = new SqlParameter("@Description", category.Description);
           paras[4] = new SqlParameter("@ParentID", category.ParentID);
           paras[5] = new SqlParameter("@Description", category.Description);
           paras[6] = new SqlParameter("@SortOrder", category.SortOrder);
           paras[7] = new SqlParameter("@IsPublished", category.IsPublished);

           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(Category category)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[8];
           paras[0] = new SqlParameter("@CategoryID", category.CategoryID);
           paras[1] = new SqlParameter("@Name", category.Name);
           paras[2] = new SqlParameter("@ImageUrl", category.ImageUrl);
           paras[3] = new SqlParameter("@Description", category.Description);
           paras[4] = new SqlParameter("@ParentID", category.ParentID);
           paras[5] = new SqlParameter("@Description", category.Description);
           paras[6] = new SqlParameter("@SortOrder", category.SortOrder);
           paras[7] = new SqlParameter("@IsPublished", category.IsPublished);

           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(Category category)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@CategoryID", category.CategoryID);
         
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}