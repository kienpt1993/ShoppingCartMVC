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
    class PaymenMethodsBLL
    {
     DBExecute _db;
     public PaymenMethodsBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(PaymenMethods paymenMethods)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[2];
           paras[0] = new SqlParameter("@Name", paymenMethods.Name);
           paras[1] = new SqlParameter("@PaymenMethodsID", paymenMethods.PaymenMethodsID);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(PaymenMethods paymenMethods)
       {
            string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@Name", paymenMethods.Name);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(int paymenMethodID)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@ProductID", paymenMethodID);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}