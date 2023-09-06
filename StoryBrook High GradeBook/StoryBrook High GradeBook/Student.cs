using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StoryBrook_High_GradeBook.Records;
using StoryBrook_High_GradeBook.Services;
using StoryBrook_High_GradeBook;
using static StoryBrook_High_GradeBook.Program;

namespace StoryBrook_High_GradeBook
{
    public class Student
    {

        #region Data Fields

        private string _firstName;
        private string _middleInitial;
        private string _lastName;
        private int _age;
        private string _studentID;
        private double _overallGPA;
        private double _biologyAverage;
        private double _algebraAverage;
        private double _physEdAverage;
        private double _englishAverage;
        private string _teacherID;
        private SchoolClass _studentClass;
        private string _classID;

        #endregion Data Fields

        #region Properties

        public string ClassID
        {
            get => _classID; set => _classID = value;
        }
        public SchoolClass StudentClass
        {
            get => _studentClass; set => _studentClass = value;
        }
        public string TeacherID
        {
            get => _teacherID; set => _teacherID = value;
        }
        public string FirstName
        {
            get => _firstName; set => _firstName = value;
        }

        public string MiddleInitial
        {
            get => _middleInitial; set => _middleInitial = value;
        }

        public string LastName
        {
            get => _lastName; set => _lastName = value;
        }

        public int Age
        {
            get => _age; set => _age = value;
        }

        public string StudentID
        {
            get => _studentID; set => _studentID = value;
        }

        public double OverallGPA
        {
            get => _overallGPA; set => _overallGPA = value;
        }

        public double BiologyAverage
        {
            get => _biologyAverage; set => _biologyAverage = value;
        }

        public double AlgebraAverage
        {
            get => _algebraAverage; set => _algebraAverage = value;
        }

        public double PhysEdAverage
        {
            get => _physEdAverage; set => _physEdAverage = value;
        }

        public double EnglishAverage
        {
            get => _englishAverage; set => _englishAverage = value;
        }

        #endregion Properties

        #region Student Grades Collection

        public Dictionary<string, double> Grades = new Dictionary<string, double>();

        #endregion Student Grades Collection
        
        #region Student Methods
        public void AddGrade(string key, double value)
        {
            Grades.Add(key, value);
        }
        #endregion Student Methods


        public static void AddStudent(SchoolDirectory thisDirectory)
        {
            Console.Clear();
            Console.CursorVisible = true;
            Student student = new Student();
            Random rnd = new Random();

            Console.Write("What is the Student's first name? ");
            student.FirstName = Console.ReadLine();
            Console.Write("What is the Student's last name? ");
            student.LastName = Console.ReadLine();
            Console.Write("What is the Student's middle initial? ");
            student.MiddleInitial = Console.ReadLine();
            Console.Write("What is the Student's age? ");
            student.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the Student's Student ID? ");
            student.StudentID = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Loading Grades...");
            Console.WriteLine();
            student.AddGrade("Algebra", student.AlgebraAverage = rnd.Next(50, 101));
            student.AddGrade("Biology", student.BiologyAverage = rnd.Next(60, 101));
            student.AddGrade("PhysEd", student.PhysEdAverage = rnd.Next(40, 101));
            student.AddGrade("English", student.EnglishAverage = rnd.Next(70, 101));
            student.OverallGPA = CalculateStudentGPA.CalculateGPA(student);

            Console.Write("What is the Student's Teacher's ID? ");
            student.TeacherID = Console.ReadLine();
            Console.Write("What is the Student's Class ID? ");
            student.ClassID = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Thank you!");

            thisDirectory.SchoolStudents.Add(student);

            foreach (SchoolClass schoolclass in thisDirectory.SchoolClasses)
            {
                if (student.ClassID == schoolclass.ClassID)
                {
                    schoolclass.Students.Add(student);
                    schoolclass.NumberOfStudents++;

                }
            }
            foreach (Teacher teacher in thisDirectory.SchoolTeachers)
            {
                if (student.TeacherID == teacher.TeacherID)
                {
                    teacher.classStudents.Add(student);

                }
            }

            Console.Clear();

            Menu menu = new Menu();
            Console.CursorVisible = false;
            int selectedIndex = menu.RunMainMenu(); ;
            while (menu != null)
            {
                if (selectedIndex == 0)
                {
                    menu.ViewClasses(thisDirectory);
                    break;
                }
                else if (selectedIndex == 1)
                {
                    menu.ViewTeachers(thisDirectory);
                    break;
                }
                else if (selectedIndex == 2)
                {
                    menu.ViewStudents(thisDirectory);
                    break;
                }
                else if (selectedIndex == 3)
                {
                    SchoolClass.AddClass(thisDirectory);
                }
                else if (selectedIndex == 4)
                {
                    Student.AddStudent(thisDirectory);
                }
                else if (selectedIndex == 30)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
