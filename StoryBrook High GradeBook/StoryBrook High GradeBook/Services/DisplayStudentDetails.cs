using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Services
{
    public static class DisplayStudentDetails
    {
        public static int DisplayStudentStats(Student student)
        {
            Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}");
            Console.WriteLine($"Student ID: {student.StudentID}");
            Console.WriteLine($"Teacher ID: {student.TeacherID}");
            Console.WriteLine($"Class ID: {student.ClassID}");
            Console.WriteLine();
            Console.WriteLine($"Overall GPA: {student.OverallGPA}");
            Console.WriteLine("Student Averages per subject: ");
            Console.WriteLine();
            Console.WriteLine($"     Algebra: {student.AlgebraAverage}");
            Console.WriteLine($"     Biology: {student.BiologyAverage}");
            Console.WriteLine($"     Physical Education: {student.PhysEdAverage}");
            Console.WriteLine($"     English: {student.EnglishAverage}");
            Console.WriteLine();

            ConsoleKey keyPress2;

            ConsoleKeyInfo currentKey = Console.ReadKey(true);
            keyPress2 = currentKey.Key;

            if (keyPress2 == ConsoleKey.Backspace)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
