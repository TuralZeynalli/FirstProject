using System;
using System.Collections.Generic;
using System.Text;

namespace First_project
{
    public class ProjectManager : Workers
    {
        public ProjectManager(string name, string surname, int age, int salary, int startEnd) : base(name, surname, age, salary, startEnd) { }

       public void CreateProject (string song) 
       {
            Console.WriteLine($"{Name} {Surname} created {song}");
       }
    }
   
}
