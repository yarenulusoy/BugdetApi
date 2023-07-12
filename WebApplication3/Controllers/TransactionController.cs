using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
