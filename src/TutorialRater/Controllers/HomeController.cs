using Microsoft.AspNet.Mvc;
using TutorialRater.ViewModels;
using TutorialRater.Services;

namespace TutorialRater.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private ITutorialData _tutorialData;

        public HomeController(ITutorialData tutorialData, IGreeter greeter)
        {
            _tutorialData = tutorialData;
            _greeter = greeter;
        }
        public ViewResult Index()
        {
            var model = new HomePageViewModel();
            model.Tutorials = _tutorialData.GetAll();
            model.CurrentGreeting = _greeter.GetGreeting();

            return View(model);
        }
    }
}
