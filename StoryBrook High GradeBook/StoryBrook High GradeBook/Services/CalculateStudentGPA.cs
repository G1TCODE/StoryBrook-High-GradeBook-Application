using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryBrook_High_GradeBook;
using StoryBrook_High_GradeBook.Records;

namespace StoryBrook_High_GradeBook.Services
{
    public static class CalculateStudentGPA
    {
        public static double CalculateGPA(Student student)
        {
            double counter = 0;
            double result = 0;

            foreach (KeyValuePair<string, double> kvp in student.Grades)
            {
                counter += kvp.Value;
            }
            result = counter / student.Grades.Count;

            if (result >= 95)
            {
                student.OverallGPA = 4.0;
            }
            else if (result >= 90 && result < 95)
            {
                student.OverallGPA = 3.7;
            }
            else if (result >= 85 && result < 90)
            {
                student.OverallGPA = 3.4;
            }
            else if (result >= 80 && result < 85)
            {
                student.OverallGPA = 3.0;
            }
            else if (result >= 75 && result < 80)
            {
                student.OverallGPA = 2.7;
            }
            else if (result >= 70 && result < 75)
            {
                student.OverallGPA = 2.4;
            }
            else if (result >= 65 && result < 70)
            {
                student.OverallGPA = 2.0;
            }
            else if (result < 65)
            {
                student.OverallGPA = 0;
            }
            return student.OverallGPA;
        }
    }
}
