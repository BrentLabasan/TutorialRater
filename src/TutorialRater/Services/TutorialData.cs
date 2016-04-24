using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialRater.Models;

namespace TutorialRater.Services
{
    public interface ITutorialData
    {
        IEnumerable<Tutorial> GetAll();
    }

    // 
    public class InMemoryTutorialData : ITutorialData
    {
        public InMemoryTutorialData()
        {
            _tutorials = new List<Tutorial>
            {
                new Tutorial {Id = 1, Url="http://django.com" },
                new Tutorial {Id = 2, Url="http://ruby.com" },
                new Tutorial {Id = 3, Url="http://python.com" }
            };
        }

        public IEnumerable<Tutorial> GetAll()
        {
            return _tutorials;
        }

        List<Tutorial> _tutorials;
    }
}
