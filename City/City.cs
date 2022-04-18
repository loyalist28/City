using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    internal class City
    {
        List<Person> people = new List<Person>();

        public List<Person> People 
        {
            get
            {
                return people;
            }
        }

        public City(Person[] personsArr)
        {
            foreach(Person p in personsArr)
            {
                People.Add(p);
            }
        }
    }
}
