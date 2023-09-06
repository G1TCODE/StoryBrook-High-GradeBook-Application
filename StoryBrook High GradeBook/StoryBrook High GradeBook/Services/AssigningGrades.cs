using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Services
{
    public static class AssigningGrades
    {
        public static void AssignStudentGrades(SchoolDirectory thisDirectory)
        {
            Random rnd = new Random();

            foreach (Student student in thisDirectory.SchoolStudents)
            {
                student.AddGrade("Algebra", student.AlgebraAverage = rnd.Next(50, 101));
                student.AddGrade("Biology", student.BiologyAverage = rnd.Next(60, 101));
                student.AddGrade("PhysEd", student.PhysEdAverage = rnd.Next(40, 101));
                student.AddGrade("English", student.EnglishAverage = rnd.Next(70, 101));
                student.OverallGPA = CalculateStudentGPA.CalculateGPA(student);
            }
        }
    }
}
