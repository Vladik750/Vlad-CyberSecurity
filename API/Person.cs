using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Person:IData
    {
        public string name;
        public string job; 
        public int age;
        public double salary;
        public bool isMarried;

        public Person(string name,  string job, int age, double salary, bool isMarried)
        {
            this.name = name;
            this.job = job;
            this.age = age;
            this.salary = salary;
            this.isMarried = isMarried;
        }

        public void ShowData()
        {
            Console.WriteLine("Person:\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age.ToString());
            Console.WriteLine("Job: " + job);
            Console.WriteLine("Salary: " + salary.ToString());
            if(isMarried)
            {
                Console.WriteLine("Married.");
            }
            else
            {
                Console.WriteLine("Not married.");
            }
        }

    }

}
