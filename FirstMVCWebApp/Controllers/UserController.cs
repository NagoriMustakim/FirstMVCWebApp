using Microsoft.AspNetCore.Mvc;

namespace FirstMVCWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public int Deatils(int id)
        {
            return id;
        }
    }
}
