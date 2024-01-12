using System;
using System.Collections.Generic;
using System.Text;

namespace First_project
{
    public class Accountant : Workers
    {
       public Accountant(string name, string surname, int age, int salary, int startEnd) : base(name, surname, age, salary, startEnd) { }

        public void ShowSalary(Workers[] workers) 
       {
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name} {worker.Surname} his salary is {worker.Salary}");
            }       
        }

        public void ShowSalaryAvarage(Workers[] workers)

        {
            int sum = 0;
            foreach (var worker in workers)
            {
                sum += worker.Salary;
            }

            int avarage = sum / workers.Length;
            Console.WriteLine($"Worker's salary avarage is {avarage} $");
        }
    }
}
