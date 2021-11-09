using System;
using System.Collections.Generic;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            //filling the server with some data
            Pet pet1 = new Pet("Dog", "Rex", 3, true);
            Pet pet2 = new Pet("Cat", "Molly", 5, false);
            Person person1 = new Person("Mike", "Pilot", 35, 23000, false);
            Person person2 = new Person("Ann", "Artist", 23, 17000, true);

            List<IData> serverItems = new List<IData>();
            //serverItems.Add(person2);
            serverItems.Add(pet1);
            serverItems.Add(person1);
            serverItems.Add(pet2);

            Server server = new Server(serverItems);
            //possible requests: "Get person" & "Get pet"
            //returns first person/pet on the server
            user.SendRequest(server);
        }
    }
}
