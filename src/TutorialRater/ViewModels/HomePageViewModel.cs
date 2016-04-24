using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialRater.Entities;

namespace TutorialRater.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Tutorial> Tutorials { get; set; }
        public string CurrentGreeting { get; set; }
    }
}
