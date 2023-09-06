using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Services
{
    public static class FindHighestGrades
    {
        public static void SortHighest(List<Student> studentList)
        {
            Student tempStudent = new Student();

            for (int i = 0; i < studentList.Count - 1; i++)
            {
                for (int j = i + 1; j < studentList.Count; j++)
                {
                    if (studentList[j].OverallGPA < studentList[i].OverallGPA)
                    {
                        tempStudent = studentList[i];
                        studentList[i] = studentList[j];
                        studentList[j] = tempStudent;
                    }
                }
            }
        }

        public static void SortHighestClass(SchoolDirectory dir)
        {
            SchoolClass tempClass = new SchoolClass();

            for (int i = 0; i < dir.SchoolClasses.Count - 1; i++)
            {
                for (int j = i + 1; j < dir.SchoolClasses.Count; j++)
                {
                    if (dir.SchoolClasses[j].OverallClassGPA < dir.SchoolClasses[i].OverallClassGPA)
                    {
                        tempClass = dir.SchoolClasses[i];
                        dir.SchoolClasses[i] = dir.SchoolClasses[j];
                        dir.SchoolClasses[j] = tempClass;
                    }
                }
            }
        }
    }
}
