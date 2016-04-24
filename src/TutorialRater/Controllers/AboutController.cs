using Microsoft.AspNet.Mvc;

namespace TutorialRater.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "555-555-5555";
        }

        public string Country()
        {
            return "USA";
        }
    }
}
