using System;
using System.Collections.Generic;
using System.Text;

namespace First_project
{
    public class Developers : Workers
    {

        public string ProgrammingLanguage { get; set; }   
        public string Wings { get; set; }
        public int InternShipYears { get; set; }

       public Developers(string name, string surname, int age, int salary, string programmingLanguage, string wings, int internShip, int startEnd) : base(name, surname, age, salary, startEnd)
       {
            ProgrammingLanguage = programmingLanguage;
            Wings = wings;
            InternShipYears = internShip;
       }

        
        public void ShowStack(Developers[] workers) 
        
        {
            Console.WriteLine("Developer's features are at the bottom");
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name} {worker.Surname}, his wing is {worker.Wings}, his internship year is {worker.InternShipYears}");
            }
        }
    }
}
