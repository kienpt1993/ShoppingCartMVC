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
    class NewsBLL
    {
    DBExecute _db;
    public NewsBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(News news)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[7];
           paras[0] = new SqlParameter("@NewsID", news.NewsID);
           paras[1] = new SqlParameter("@Name", news.Name);
           paras[2] = new SqlParameter("@ImageUrl", news.ImageUrl);
           paras[3] = new SqlParameter("@Hits", news.Hits);
           paras[4] = new SqlParameter("@Content", news.Content);
           paras[5] = new SqlParameter("@CreateDate", news.CreateDate);
           paras[6] = new SqlParameter("@Author", news.Author);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(News news)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[7];
           paras[0] = new SqlParameter("@NewsID", news.NewsID);
           paras[1] = new SqlParameter("@Name", news.Name);
           paras[2] = new SqlParameter("@ImageUrl", news.ImageUrl);
           paras[3] = new SqlParameter("@Hits", news.Hits);
           paras[4] = new SqlParameter("@Content", news.Content);
           paras[5] = new SqlParameter("@CreateDate", news.CreateDate);
           paras[6] = new SqlParameter("@Author", news.Author);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(int newsID)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[7];
           paras[0] = new SqlParameter("@NewsID", newsID);
         
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}