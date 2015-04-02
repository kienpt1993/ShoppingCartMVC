using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataProvider
{
    public abstract class DBExecute
    {
        // Xay dung cac phuong thuc xu ly du lieu
        public abstract SqlDataReader Execute_DataReader(string Text, SqlParameter[] paras, CommandType cmdType);
        public abstract DataTable Execute_Table(string Text, SqlParameter[] paras, CommandType cmdType);
        public abstract DataSet Execute_Tables(string Text, SqlParameter[] paras, CommandType cmdType);
        public abstract Object Execute_Object(string Text, SqlParameter[] paras, CommandType cmdType);
        public abstract int Execute_Modify(string Text, SqlParameter[] paras, CommandType cmdType);
    }
}
