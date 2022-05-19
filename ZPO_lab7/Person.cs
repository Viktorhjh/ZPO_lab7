using System;
using System.Collections.Generic;
using System.Text;

namespace ZPO_lab7
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person(string name, string surname, int year, string city)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = year;
            this.City = city;
        }

    }
}
