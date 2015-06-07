using ShopingCartEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartMvc.Controllers
{
    public class CustomerAccountController : Controller
    {
        //
        // GET: /CustomerAccount/
        public ActionResult Index()
        {
            return View();
        }
        // Action nay chi hien thi, khong xu ly gi ca
        public ActionResult MyRegister()
        {
            return View(new Customer { });
        }            
        // Action nayxu ly, khong hien thi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MyRegister(Customer customer)   
        {
            if (ModelState.IsValid)
            {
                using (ShoppingCartEntities db = new ShoppingCartEntities())
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();

                }
            }
            // xong roi thi quay ve trang khac - login chang han
            // If we got this far, something failed, redisplay form
            return RedirectToAction("Index");
        }
	}
}