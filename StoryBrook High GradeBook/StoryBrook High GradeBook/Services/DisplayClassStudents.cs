using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Services
{
    public class DisplayClassStudents
    {
        public static void DisplayStudents(SchoolClass schoolclass)
        {
            ConsoleKey keyPress1;

            ConsoleKeyInfo currentKey = Console.ReadKey(true);
            keyPress1 = currentKey.Key;

            if (keyPress1 == ConsoleKey.Backspace)
            {
                return;
            }

            Console.WriteLine($"Class Name: {schoolclass.Name}");
            Console.WriteLine($"Teacher: {schoolclass.TeacherName}");
            Console.WriteLine();
            Console.WriteLine("Students: ");
            foreach (Student student in schoolclass.Students)
            {
                Console.WriteLine($"     {student.LastName}, {student.FirstName[0]}.{student.MiddleInitial}. - GPA: {student.OverallGPA} ");
            }
        }
    }
}
