using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Services
{
    public static class CalculateClassGPA
    {
        public static void ClassGPACalc(SchoolClass thisClass)
        {
            double biologyctr = 0;
            double alegbractr = 0;
            double physEdctr = 0;
            double englishctr = 0;

            foreach (Student student in thisClass.Students)
            {
                biologyctr += student.BiologyAverage;
                alegbractr += student.AlgebraAverage;
                physEdctr += student.PhysEdAverage;
                englishctr  += student.EnglishAverage;
            }

            biologyctr /= thisClass.NumberOfStudents;
            alegbractr /= thisClass.NumberOfStudents;
            physEdctr /= thisClass.NumberOfStudents;
            englishctr /= thisClass.NumberOfStudents;

            thisClass.AlgebraAverage = alegbractr;
            thisClass.BiologyAverage = biologyctr;
            thisClass.PhysEdAverage = physEdctr;
            thisClass.EnglishAverage = englishctr;

            double result = (thisClass.BiologyAverage + thisClass.AlgebraAverage + thisClass.PhysEdAverage + thisClass.EnglishAverage) / 4;

            if (result >= 95)
            {
                thisClass.OverallClassGPA = 4.0;
            }
            else if (result >= 90 && result < 95)
            {
                thisClass.OverallClassGPA = 3.7;
            }
            else if (result >= 85 && result < 90)
            {
                thisClass.OverallClassGPA = 3.4;
            }
            else if (result >= 80 && result < 85)
            {
                thisClass.OverallClassGPA = 3.0;
            }
            else if (result >= 75 && result < 80)
            {
                thisClass.OverallClassGPA = 2.7;
            }
            else if (result >= 70 && result < 75)
            {
                thisClass.OverallClassGPA = 2.4;
            }
            else if (result >= 65 && result < 70)
            {
                thisClass.OverallClassGPA = 2.0;
            }
            else if (result < 65)
            {
                thisClass.OverallClassGPA = 0;
            }
        }
    }
}
