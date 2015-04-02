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
    class PageBLL
    {
     DBExecute _db;
     public PageBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(Page page)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[4];
           paras[0] = new SqlParameter("@PageID", page.PageID);
           paras[1] = new SqlParameter("@Name", page.Name);
           paras[2] = new SqlParameter("@Content", page.Content);
           paras[3] = new SqlParameter("@Alias", page.Alias);

           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(Page page)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[3];
           paras[0] = new SqlParameter("@Name", page.Name);
           paras[1] = new SqlParameter("@Content", page.Content);
           paras[2] = new SqlParameter("@Alias", page.Alias);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(int pageID)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@PageID", pageID);
         
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}