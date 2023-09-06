using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook
{
    public class SchoolDirectory
    {
        #region Data Fields
        private int _numberOfClasses;
        private double _averageGPA;
        #endregion Data Fields

        #region Properties
        public int NumberOfClasses
        {
            get => _numberOfClasses; set => _numberOfClasses = value;
        }

        public string AverageGPA
        {
            get => AverageGPA; set => AverageGPA = value;
        }

        #endregion Properties

        #region Collections

        public List<Teacher> SchoolTeachers = new List<Teacher>();

        public List<Student> SchoolStudents = new List<Student>();

        public List<SchoolClass> SchoolClasses = new List<SchoolClass>();

        #endregion Collections

    }
}
