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
   public  class CustomerBLL
    {
       DBExecute _db;
       public CustomerBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(Customer customer)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[5];
           paras[0] = new SqlParameter("@CustomerID", customer.CustomerID);
           paras[1] = new SqlParameter("@Name", customer.Name);
           paras[2] = new SqlParameter("@Phone", customer.Phone);
           paras[3] = new SqlParameter("@DOB", customer.DOB);
           paras[4] = new SqlParameter("@Adress", customer.Adress);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(Customer customer)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[5];
           paras[0] = new SqlParameter("@CustomerID", customer.CustomerID);
           paras[1] = new SqlParameter("@Name", customer.Name);
           paras[2] = new SqlParameter("@Phone", customer.Phone);
           paras[3] = new SqlParameter("@DOB", customer.DOB);
           paras[4] = new SqlParameter("@Adress", customer.Adress);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(int customerID)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@CustomerID",customerID);
         
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}