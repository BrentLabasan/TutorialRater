using Microsoft.AspNet.Mvc;
using TutorialRater.Models;

namespace TutorialRater.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var model = new Tutorial { Id = 1, Url = "http://django.com" };

            return View(model);
        }
    }
}
