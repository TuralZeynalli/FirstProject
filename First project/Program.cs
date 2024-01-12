using System;
using System.Collections.Generic;
using System.Text;

namespace First_project
{
    class Program
    {
        static void Main(string[] args)
        {         
            ProjectManager manager = new ProjectManager("James", "Hetfield", 60, 2000, 1981);

            Accountant accountant = new Accountant("Lars", "Ulrich", 60, 2000, 1981);

            Developers developer1 = new Developers("Kirk", "Hammet", 61, 1800, "CSharp", "Frontend", 16, 1983);
            Developers developer2 = new Developers("Robert", "Trujillo", 59, 1500, "Pyhton", "Backend", 16, 2003);

            Workers[] allWorkers = new Workers[] { manager, accountant, developer1, developer2 };

            AllWorkers(allWorkers);

            GetYoungWorkers(allWorkers);

            WorkerStart(allWorkers);

            accountant.ShowSalary(allWorkers);

            accountant.ShowSalaryAvarage(allWorkers);

            Developers[] developers = new Developers[] { developer1, developer2 };

            developer1.ShowStack(developers);

            manager.CreateProject("Enter Sandman");
        }

        public static void AllWorkers(Workers[] workers) 
        
        {
            int line = 1;
            Console.WriteLine("Workers and their features are at the bottom:");

            foreach (var worker in workers)
            {
                Console.WriteLine($"{line} {worker.Name}  {worker.Surname};"); // sual? axicinci workere nece edekki ; yox . olsun?
                line++;
            }
        } 

        public static void GetYoungWorkers (Workers[] workers) 
        
        {
            int age = 100;
            string young = "";

            foreach (var worker in workers)
            {
                if (worker.Age < age)
                {
                   age = worker.Age;
                   young = worker.Name; // soyad nece olsun.
                }
            }
            Console.WriteLine($"The youngest worker is {young}. he is {age} years old");
        }

        public static void WorkerStart(Workers[] workers)

        {
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name} started his job in {worker.Start}");
            }
        }
    }
}
