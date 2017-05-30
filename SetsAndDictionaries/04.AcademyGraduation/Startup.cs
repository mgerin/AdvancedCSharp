using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AcademyGraduation
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, double[]>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse).ToArray();

                students.Add(name, grades);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
