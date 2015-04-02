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
   public  class ImageBLL
    {
       DBExecute _db;
       public ImageBLL()
       {
           _db = new SQLExecute();
       }
       int Insert(Image image)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[3];
           paras[0] = new SqlParameter("@ImageID", image.ImageID);
           paras[1] = new SqlParameter("@ProductID", image.ProductID);
           paras[2] = new SqlParameter("@ImgUrl", image.ImageUrl);

           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);           
       }
       int Update(Image image)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[3];
           paras[0] = new SqlParameter("@ImageID", image.ImageID);
           paras[1] = new SqlParameter("@ProductID", image.ProductID);
           paras[2] = new SqlParameter("@ImgUrl", image.ImageUrl);
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);  

       }
       public int Delete(int  imageID)
       {
           string proc = "insert into...";
           SqlParameter[] paras = new SqlParameter[1];
           paras[0] = new SqlParameter("@ImageID", imageID);
         
           return _db.Execute_Modify("Ten thu tuc", paras, CommandType.StoredProcedure);
       }
       public DataTable GetDataTable()
       {
           return null;
       }
    }
}