using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryBrook_High_GradeBook.Records;
using StoryBrook_High_GradeBook.Services;
using static StoryBrook_High_GradeBook.Program;

namespace StoryBrook_High_GradeBook
{
    public class SchoolClass
    {

        #region Data Fields

        private string _classID;
        private string _name;
        private int _numberOfStudents;
        private string _teacherName;
        private double _biologyAverage;
        private double _algebraAverage;
        private double _physEdAverage;
        private double _englishAverage;
        private string _teacherID;
        private double _overallClassGPA;

        #endregion Data Fields

        #region Properties

        public double OverallClassGPA
        {
            get => _overallClassGPA; set => _overallClassGPA = value;
        }
        public string ClassID
        {
            get => _classID; set => _classID = value;
        }
        public string Name
        {
            get => _name; set => _name = value;
        }

        public int NumberOfStudents
        {
            get => _numberOfStudents; set => _numberOfStudents = value;
        }

        public string TeacherName
        {
            get => _teacherName; set => _teacherName = value;
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

        public string TeacherID
        {
            get => _teacherID; set => _teacherID = value;
        }

        #endregion Properties

        #region Collections

        public List<Student> Students = new List<Student>();

        #endregion Collections

        public static void AddClass(SchoolDirectory thisDirectory)
        {
            Console.Clear();
            Console.CursorVisible = true;
            SchoolClass schoolClass = new SchoolClass();

            Console.Write("What is the class' name? ");
            schoolClass.Name = Console.ReadLine();
            Console.Write("What is the class' Class ID? ");
            schoolClass.ClassID = Console.ReadLine();
            Console.Write("What is the class' teacher's name? ");
            schoolClass.TeacherName = Console.ReadLine();
            Console.Write("What is the class' Teacher ID? ");
            schoolClass.TeacherID = Console.ReadLine();

            schoolClass.NumberOfStudents = 0;
            schoolClass.OverallClassGPA = 0;
            schoolClass.BiologyAverage = 0;
            schoolClass.AlgebraAverage = 0;
            schoolClass.PhysEdAverage = 0;
            schoolClass.EnglishAverage = 0;

            Console.WriteLine();
            Console.WriteLine("Thank you!");

            Console.Clear();

            thisDirectory.SchoolClasses.Add(schoolClass);

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
                    Console.Clear();
                }
                else if (selectedIndex == 4)
                {
                    Student.AddStudent(thisDirectory);
                    Console.Clear();
                }
                else if (selectedIndex == 30)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}





//ConsoleKey keyPress2;

//ConsoleKeyInfo currentKey = Console.ReadKey(true);
//keyPress2 = currentKey.Key;

//if (keyPress2 == ConsoleKey.Backspace)
//{
//    return 0;
//}
//else
//{
//    return 1;
//}
