using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book(" My Book ");
            while(true)
            {
                Console.WriteLine("Enter the grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }
            var stat  = book.GetStatistics();
            Console.WriteLine($"The lowes grade is {stat.Low}");
            Console.WriteLine($"The highest grade is {stat.High}");
            Console.WriteLine($"The average grade is {stat.Average:N1}");
        }
    }
}
