using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Person> list = new List<Person>();

            while (command[0] != "End")
            {
                string name = command[0];
                string ID = command[1];
                int age = int.Parse(command[2]);

                Person person = new Person(name, ID, age);
                list.Add(person);

                 command = Console.ReadLine().Split();
            }

            if (command[0] == "End")
            {
                var result = list.OrderBy(person => person.Age);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
