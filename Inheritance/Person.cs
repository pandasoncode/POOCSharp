﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public string Surnames { get; set; }
        public int Age { get; set; }
        protected string DNI = "";

        public Person(string name, string surnames, int age)
        {
            Console.WriteLine("Person constructor");
            Name = name;
            Surnames = surnames;
            Age = age;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Surnames: {Surnames}, Age: {Age}");
        }

        public virtual void BetterShow()
        {
            Console.WriteLine($"The person is named {Name} {Surnames}");
        }
    }
}
