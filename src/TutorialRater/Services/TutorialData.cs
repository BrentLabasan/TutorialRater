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
        void Add(Tutorial newTutorial);
    }

    // 
    public class InMemoryTutorialData : ITutorialData
    {
        static InMemoryTutorialData()
        {
            _tutorials = new List<Tutorial>
            {
                new Tutorial {Id = 1, Url="http://django.com" },
                new Tutorial {Id = 2, Url="http://ruby.com" },
                new Tutorial {Id = 3, Url="http://python.com" }
            };
        }

        public void Add(Tutorial newTutorial)
        {
            newTutorial.Id = _tutorials.Max(r => r.Id) + 1;
            _tutorials.Add(newTutorial);

        }

        public Tutorial Get(int id)
        {
            return _tutorials.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Tutorial> GetAll()
        {
            return _tutorials;
        }

        static List<Tutorial> _tutorials;
    }
}
