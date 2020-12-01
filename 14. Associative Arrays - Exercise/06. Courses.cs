using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] inputTokens = input.Split(" : ");
                string courseName = inputTokens[0];
                string name = inputTokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(name);
                }
                else
                {
                    courses[courseName].Add(name);
                }
                input = Console.ReadLine();
            }
            foreach (var pair in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine(pair.Key + ": " + pair.Value.Count);
                List<string> students = pair.Value;
                students.Sort();

                foreach (string student in students)
                {
                    Console.WriteLine("-- " + student);
                }
                
            }
        }
    }

}
