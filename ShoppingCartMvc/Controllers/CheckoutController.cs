using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartMvc.Controllers
{
    public class CheckoutController : Controller
    {
        //
        // GET: /Checkout/
        public ActionResult Index()
        {
            return View();
        }
	}
}