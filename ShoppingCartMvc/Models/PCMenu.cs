using ShopingCartEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

 
    public class PCMenu
    {

        static ShoppingCartEntities db = new ShoppingCartEntities();
       public static string ChildCategory(int parentID)
        {
           string str = null;
           
           return str;
       }
        public static string Category()
        {
            string str = null;

            foreach (var item in db.Categories)
            {
                str += "  <div class=\"panel panel-default\">";
                str += "               <div class=\"panel-heading\">";
                str += "            <h4 class=\"panel-title\">";

                str += "                   <a data-toggle=\"collapse\" data-parent=\"#accordian\" href=\"#sportswear\">";
                str += "                       <span class=\"badge pull-right\"><i class=\"fa fa-plus\"></i></span>";
                  str+=     item.Name;
                str += "               </a>";
                str += "            </h4>";
                str += "         </div>";
                str += "         <div id=\"sportswear\" class=\"panel-collapse collapse\">";
                str += "           <div class=\"panel-body\">";
                str += "               <ul>";
                str += "                   <li><a href=\"#\">";
                str += "kien";
                str+="</a></li>";

                str += "               </ul>";
                str += "           </div>";
                str += "       </div>";
                str += "   </div>";


            }


            return str;

        }
    }
