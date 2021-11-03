using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Pet:IData
    {
        private string animal;
        private string name;
        private int age;
        private bool hasOwner;

        public Pet(string animal, string name, int age, bool hasOwner)
        {
            this.animal = animal;
            this.name = name;
            this.age = age;
            this.hasOwner = hasOwner;
        }

        public void ShowData()
        {
            Console.WriteLine("Pet\n");
            Console.WriteLine("Animal: " + animal);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age.ToString());
            if(hasOwner)
            {
                Console.WriteLine("Has owner.");
            }
            else
            {
                Console.WriteLine("Has no owner.");
            }
        }
    }
}
