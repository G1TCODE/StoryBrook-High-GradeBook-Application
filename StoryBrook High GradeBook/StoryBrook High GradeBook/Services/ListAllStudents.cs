using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Services
{
    internal class ListAllStudents
    {
        public static void ListAllStudentsNow(SchoolDirectory thisDirectory)
        {
            foreach (Student student in thisDirectory.SchoolStudents)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Student: {student.LastName}, {student.FirstName[0]}.{student.MiddleInitial}: ");
                foreach (SchoolClass schoolclass in thisDirectory.SchoolClasses)
                {
                    if (schoolclass.ClassID == student.ClassID)
                    {
                        Console.WriteLine($"Class: {schoolclass.Name}");
                    }
                }

                foreach (Teacher teacher in thisDirectory.SchoolTeachers)
                {
                    if (teacher.TeacherID == student.TeacherID)
                    {
                        Console.WriteLine($"Teacher: {teacher.TeacherName}");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Grades: ");
                Console.WriteLine($"     Algebra: {student.AlgebraAverage}");
                Console.WriteLine($"     Biology: {student.BiologyAverage}");
                Console.WriteLine($"     PhysEd: {student.PhysEdAverage}");
                Console.WriteLine($"     English: {student.EnglishAverage}");
                Console.WriteLine();
                Console.WriteLine($"     Overall average: " +
                    $"{(student.AlgebraAverage + student.BiologyAverage + student.PhysEdAverage + student.EnglishAverage) / 4}");
                Console.WriteLine($"     Overall GPA: {student.OverallGPA}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
