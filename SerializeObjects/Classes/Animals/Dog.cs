using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializeObjects.Classes
{
    public class Dog : IAnimal
    {
        private string _name;
        private DateTime? _bithdate;
        private List<Dog> _descendats = new List<Dog>();
        private int? _pedigree;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public DateTime? BirthDate
        {
            get
            {
                return _bithdate;
            }

            set
            {
                _bithdate = value;
            }
        }



        public int? PedigreeNumber
        {
            get
            {
                return _pedigree;
            }
            set
            {
                _pedigree = value;
            }
        }

        public IList Desendants
        {
            get
            {
                return _descendats;
            }
        }

        public bool AddDescendants(Dog descendant)
        {
            _descendats.Add(descendant);
            return true;
        }

    }
}
