using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Services
{
    public class TeacherDetails
    {
        public static int DisplayTeacherStats(Teacher teacher)
        {
            Console.WriteLine($"Teacher Name: {teacher.TeacherName}");
            Console.WriteLine($"Teacher ID: {teacher.TeacherID}");
            Console.WriteLine($"Class Name: {teacher.ClassName}");
            Console.WriteLine();
            Console.WriteLine($"Overall GPA: {teacher.ClassGPA}");
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
