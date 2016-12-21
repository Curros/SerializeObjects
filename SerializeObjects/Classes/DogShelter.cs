using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeObjects.Classes
{
    public class DogShelter : ShelterBase<Dog>
    {
        public string TypeOfAnimals { get; private set; }

        public DogShelter(string name, string typeAnimals) : base(name)
        {
            this.TypeOfAnimals = typeAnimals;
        }

    }
}
