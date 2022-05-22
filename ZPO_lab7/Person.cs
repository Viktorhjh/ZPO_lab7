using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media.Imaging;

namespace ZPO_lab7
{
    public class Person
    {
        public string Name { get; set; }
 
        public string Surname { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public BitmapImage Img { get; set; }

        public Person(string name, string surname, int year, string city)
        {
            Name = name;
            Surname = surname;
            Age = year;
            City = city;
        }

        public Person(string name, string surname, int year, string city, BitmapImage img)
        {
            Name = name;
            Surname = surname;
            Age = year;
            City = city;
            Img = img;
        }
    }
}
