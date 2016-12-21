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
        string Name { get; set; }

        DateTime? BirthDate { get; set; }

        IList Desendants { get; }

    }
}
