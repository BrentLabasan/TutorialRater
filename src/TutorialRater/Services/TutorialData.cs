using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialRater.Entities;

namespace TutorialRater.Services
{
    public interface ITutorialData
    {
        IEnumerable<Tutorial> GetAll();
        Tutorial Get(int id);
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

        public Tutorial Get(int id)
        {
            return _tutorials.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Tutorial> GetAll()
        {
            return _tutorials;
        }

        List<Tutorial> _tutorials;
    }
}
