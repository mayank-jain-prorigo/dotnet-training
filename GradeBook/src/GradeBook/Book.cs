
using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            
            var result = 0.0;
            var highgrade = double.MinValue;
            var lowgrade = double.MaxValue;

            foreach ( var num in grades)
            {
                lowgrade = Math.Min(num, lowgrade);
                highgrade = Math.Max(num, highgrade);
                result += num;
            }
            result /= grades.Count;
            Console.WriteLine($"The lowes grade is {lowgrade}");
            Console.WriteLine($"The highest grade is {highgrade}");
            Console.WriteLine($"The average grade is {result:N1}");
        }
        private List<double> grades;
        private string Name;
    }
}