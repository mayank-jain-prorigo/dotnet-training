
using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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

        public Statistics ShowStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach ( var num in grades)
            {
                result.Low = Math.Min(num, result.Low);
                result.High = Math.Max(num, result.High);
                result.Average += num;
            }
            result.Average /= grades.Count;
            return result;
        }
        private List<double> grades;
        private string Name;
    }
}