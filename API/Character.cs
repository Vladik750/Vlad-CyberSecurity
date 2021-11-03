using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Character
    {
        public string name;
        public string gender;
        public string job; 
        public int age;
        public double salary;
        public bool isMarried;

        public Character(string name, string gender, string job, int age, double salary, bool isMarried)
        {
            this.name = name;
            this.gender = gender;
            this.job = job;
            this.age = age;
            this.salary = salary;
            this.isMarried = isMarried;
        }

    }

    class CharacterBuilder
    { }

}
