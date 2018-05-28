using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataModels.Models;


namespace DataModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            ViewData["Message"] = "Welkom bij ons online magazijn.";

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            else
            {
                LogicLayer.LoginLogic loginLogic = new LogicLayer.LoginLogic();
                string username = loginLogic.Login(login.username, login.password);
                if (username != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("fout", "PANIEK HELM OP");
                    return View(login);
                }
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Producten(DataModels.productModels product)
        {
            ViewData["Message"] = "Bekijk hieronder onze varierende voorraad.";

            LogicLayer.ProductLogic productLogic = new LogicLayer.ProductLogic();
            List<DataModels.productModels> products = productLogic.Products();

            ViewData["producten"] = "test";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
