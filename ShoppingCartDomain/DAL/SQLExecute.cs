using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DataProvider
{
    public class SQLExecute:DBExecute
    {
        private SqlConnection cnn;
        private string connectionString;
        public SQLExecute()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        }
        public SQLExecute(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public override SqlDataReader Execute_DataReader(string Text, SqlParameter[] paras, CommandType cmdType)
        {
            using (cnn = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand(Text, cnn);
                cmd.CommandType = cmdType;
                if (paras != null)
                    cmd.Parameters.AddRange(paras);
                DataTable table = new DataTable();
                cnn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
        public override DataTable Execute_Table(string Text, SqlParameter[] paras, CommandType cmdType)
        {
            using (cnn = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand(Text, cnn);
                cmd.CommandType = cmdType;
                if (paras != null)
                    cmd.Parameters.AddRange(paras);
                DataTable table = new DataTable();
                cnn.Open();
                table.Load(cmd.ExecuteReader());
                return table;
            }
        }
        public override DataSet Execute_Tables(string Text, SqlParameter[] paras, CommandType cmdType)
        {
            using (cnn = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand(Text, cnn);
                cmd.CommandType = cmdType;
                if (paras != null)
                    cmd.Parameters.AddRange(paras);
                DataSet  ds = new DataSet();
                cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            }
        }
        public override object Execute_Object(string Text, SqlParameter[] paras, CommandType cmdType)
        {          
            using (cnn = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand(Text, cnn);
                cmd.CommandType = cmdType;
                if (paras != null)
                    cmd.Parameters.AddRange(paras);               
                cnn.Open();               
                return cmd.ExecuteScalar();
            }
        }
        public override int Execute_Modify(string Text, SqlParameter[] paras, CommandType cmdType)
        {
            using (cnn = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand(Text, cnn);
                cmd.CommandType = cmdType;
                if (paras != null)
                    cmd.Parameters.AddRange(paras);
                cnn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
