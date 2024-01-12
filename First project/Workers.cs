using System;
using System.Collections.Generic;
using System.Text;

namespace First_project
{
   public class Workers
   {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int Start { get; set; }
        public Workers(string name, string surname, int age, int salary, int startEnd)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            Start = startEnd;
        }
   }
}
