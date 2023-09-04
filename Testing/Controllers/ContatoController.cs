using Microsoft.AspNetCore.Mvc;

namespace Testing.Controller
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
    }

}