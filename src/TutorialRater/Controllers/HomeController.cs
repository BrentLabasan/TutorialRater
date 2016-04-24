using Microsoft.AspNet.Mvc;
using TutorialRater.ViewModels;
using TutorialRater.Services;
using TutorialRater.Entities;

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

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(TutorialEditViewModel model)
        {
            var tutorial = new Tutorial();
            tutorial.Url = model.Url;
            tutorial.Format = model.Format;

            _tutorialData.Add(tutorial);

            return View("Details", tutorial);
        }

        public IActionResult Details(int id)
        {
            var model = _tutorialData.Get(id);
            if (model==null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
