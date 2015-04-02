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
   public  class OrderItemBLL
    {
       DBExecute _db;
       public OrderItemBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(OrderItem orderItem)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[5];
           paras[0] = new SqlParameter("@OrderItemID", orderItem.OrtherID);
           paras[1] = new SqlParameter("@ProductID", orderItem.ProductID);
           paras[2] = new SqlParameter("@Name", orderItem.Name);
           paras[3] = new SqlParameter("@ProductID", orderItem.ProductID);
           paras[4] = new SqlParameter("@Quantily", orderItem.Quantily);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(OrderItem orderItem)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[5];
           paras[0] = new SqlParameter("@OrderItemID", orderItem.OrtherID);
           paras[1] = new SqlParameter("@ProductID", orderItem.ProductID);
           paras[2] = new SqlParameter("@Name", orderItem.Name);
           paras[3] = new SqlParameter("@ProductID", orderItem.ProductID);
           paras[4] = new SqlParameter("@Quantily", orderItem.Quantily);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(int ortherID, int productID)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@OrderItemID", ortherID);
           paras[1] = new SqlParameter("@ProductID", productID);
         
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}