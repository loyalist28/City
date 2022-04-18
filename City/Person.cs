using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    internal class Person : IEquatable<Person>
    {
        public enum Gender
        {
            Male,
            Female
        }

        int age = 0;

        public int Id { get; private set;}
        public Gender PersonGender { get; private set;}
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age 
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, string surname, Gender gender, int id)
        {
            Id = id;
            Name = name;
            Surname = surname;
            PersonGender = gender;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age {Age}, Id: {Id}";
        }
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;

            Person? other = obj as Person;
            if(other == null) return false;
            
            return Equals(other);
        }
        public override int GetHashCode()
        {
            return Id;
        }

        public bool Equals(Person? otherPerson)
        {
            if(otherPerson == null) return false;

            return Name.Equals(otherPerson.Name) && Surname.Equals(otherPerson.Surname) && Age.Equals(otherPerson.Age) && Id.Equals(otherPerson.Id);
        }
    }
}
