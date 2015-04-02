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
   public  class OrderBLL
    {
       DBExecute _db;
       public OrderBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(Order order)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[9];
           paras[0] = new SqlParameter("@OrderID", order.OrtherID);
           paras[1] = new SqlParameter("@PaymentMethod", order.PaymentMethod);
           paras[2] = new SqlParameter("@PaymentType", order.PaymentType);
           paras[3] = new SqlParameter("@ShippingMethod", order.ShippingMethod);
           paras[4] = new SqlParameter("@Status", order.Status);
           paras[5] = new SqlParameter("@DateOrdered", order.DateOrdered);
           paras[6] = new SqlParameter("@DateRicived", order.DateRicived);
           paras[7] = new SqlParameter("@CustomerID", order.CustomerID);
           paras[8] = new SqlParameter("@Amout", order.Amout);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(Order order)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[9];
           paras[0] = new SqlParameter("@OrderID", order.OrtherID);
           paras[1] = new SqlParameter("@PaymentMethod", order.PaymentMethod);
           paras[2] = new SqlParameter("@PaymentType", order.PaymentType);
           paras[3] = new SqlParameter("@ShippingMethod", order.ShippingMethod);
           paras[4] = new SqlParameter("@Status", order.Status);
           paras[5] = new SqlParameter("@DateOrdered", order.DateOrdered);
           paras[6] = new SqlParameter("@DateRicived", order.DateRicived);
           paras[7] = new SqlParameter("@CustomerID", order.CustomerID);
           paras[8] = new SqlParameter("@Amout", order.Amout);

           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(int OrderID)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@OrderID", OrderID);
         
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}