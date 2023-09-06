using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Services
{
    public static class ClassDetails
    {
        public static int DisplayClassStats(SchoolClass schoolclass)
        {

            Console.WriteLine($"Class Name: {schoolclass.Name}");
            Console.WriteLine($"Class ID: {schoolclass.ClassID}");
            Console.WriteLine($"Teacher Name: {schoolclass.TeacherName}");
            Console.WriteLine($"Teacher ID: {schoolclass.TeacherID}");
            Console.WriteLine($"Number of Students: {schoolclass.NumberOfStudents}");
            Console.WriteLine();
            Console.WriteLine("Students: ");
            Console.WriteLine();
            foreach (Student student in schoolclass.Students)
            {
                Console.WriteLine($"     {student.LastName}, {student.FirstName[0]}, {student.MiddleInitial}. - Overall GPA: {student.OverallGPA}");
            }
            CalculateClassGPA.ClassGPACalc(schoolclass);

            Console.WriteLine();
            Console.WriteLine($"Overall GPA: {schoolclass.OverallClassGPA}");
            Console.WriteLine("Class Averages per subject: ");
            Console.WriteLine();
            Console.WriteLine($"     Algebra: {schoolclass.AlgebraAverage}");
            Console.WriteLine($"     Biology: {schoolclass.BiologyAverage}");
            Console.WriteLine($"     Physical Education: {schoolclass.PhysEdAverage}");
            Console.WriteLine($"     English: {schoolclass.EnglishAverage}");

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
