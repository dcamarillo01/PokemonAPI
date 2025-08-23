using Microsoft.AspNetCore.Mvc;

namespace PL_MVC.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Pokemones() { 
        
            return View();
        }
    }
}
