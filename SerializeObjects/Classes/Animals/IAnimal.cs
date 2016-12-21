using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeObjects.Classes
{
    public interface IAnimal
    {
        DateTime? BirthDate { get; set; }

        string Name { get; set; }

        IList Desendants { get; }

    }
}
