using asptask2.Models;
using Microsoft.AspNetCore.Mvc;

namespace asptask2.Controllers
{
    public class AnstructController1 : Controller
    {

        public IActionResult Index()
        {
            Context context = new Context();
            List<Anstructor> ansModel = context.anstructors.ToList();

            return View("Index",ansModel);
        }
    }
}
