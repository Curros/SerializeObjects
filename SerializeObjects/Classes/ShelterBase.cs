using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeObjects.Classes
{
    public abstract class ShelterBase<T>
    {
        private string _name;
        private List<T> _animals;

        public string Name => _name;

        public List<T> Animals => _animals;

        public ShelterBase(string name)
        {
            _name = name;
            _animals = new List<T>();
        }

        public virtual void AddAnimal(T animal) {
            _animals.Add(animal);
        }

    }
}
