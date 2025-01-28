using Microsoft.AspNetCore.Mvc;

namespace A_Bird_Told_Me.Controllers
{
    public class BirdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
