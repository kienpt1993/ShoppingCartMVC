using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartDomain.Entities;
using ShoppingCartDomain.BLL;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Brands b = new Brands();
            b.BrandID = 12;
            b.Name = "Apple";
            b.ImageUrl = "dada";
            BrandBLL br = new BrandBLL();
            int kq =  br.Insert(b);
            Console.WriteLine(kq);
            Console.ReadKey();
        }
    }
}
