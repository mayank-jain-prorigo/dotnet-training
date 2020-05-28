using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new GradeBook(" My Book ");
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
        }
    }
}
