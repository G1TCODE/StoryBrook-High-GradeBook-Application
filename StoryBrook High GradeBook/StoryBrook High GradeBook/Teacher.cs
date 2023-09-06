using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook
{
    public class Teacher
    {
        #region Data Fields

        private string _className;
        private string _teacherName;
        private string _teacherID;
        private double _classGPA;
        private SchoolClass _teacherClass;

        #endregion Data Fields

        #region Properties

        public SchoolClass TeacherClass
        {
            get => _teacherClass; set => _teacherClass = value;
        }
        public string ClassName
        {
            get => _className; set => _className = value;
        }

        public string TeacherName
        {
            get => _teacherName; set => _teacherName = value;
        }

        public string TeacherID
        {
            get => _teacherID; set => _teacherID = value;
        }

        public double ClassGPA
        {
            get => _classGPA; set => _classGPA = value;
        }

        #endregion Properties

        #region Students Collection

        public List<Student> classStudents = new List<Student>();

        #endregion Students Collection
    }
}
