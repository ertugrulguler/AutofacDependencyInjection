using AutoFacDependencyInjection.Models;
using AutoFacDependencyInjection.Services;
using System.Web.Mvc;

namespace AutoFacDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduct Product;
        private readonly IMailService MailService;

        public HomeController(IProduct product, IMailService mailService)
        {
            Product = product;
            MailService = mailService;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}