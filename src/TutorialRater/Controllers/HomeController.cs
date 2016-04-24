using Microsoft.AspNet.Mvc;
using TutorialRater.Models;
using TutorialRater.Services;

namespace TutorialRater.Controllers
{
    public class HomeController : Controller
    {
        private ITutorialData _tutorialData;

        public HomeController(ITutorialData tutorialData)
        {
            _tutorialData = tutorialData;
        }
        public ViewResult Index()
        {
            var model = _tutorialData.GetAll();

            return View(model);
        }
    }
}
