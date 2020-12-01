using System;

namespace _01.BonusScoringSystem_29.February._2020_
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int countLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendance = 0;
            
            for (int i = 0; i < countStudents; i++)
            {
                int attendancePerStudent = int.Parse(Console.ReadLine());
                double totalBonus = attendancePerStudent  * 1.0 / countLectures * (5 + additionalBonus);
                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendance = attendancePerStudent;
                }
                
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
