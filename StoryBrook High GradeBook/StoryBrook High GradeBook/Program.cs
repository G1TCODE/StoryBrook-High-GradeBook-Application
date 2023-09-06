using StoryBrook_High_GradeBook.Data;
using StoryBrook_High_GradeBook.Services;
using System.Data;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Text;
using System.Reflection.Emit;
using System.ComponentModel.Design;
using static StoryBrook_High_GradeBook.Program;

namespace StoryBrook_High_GradeBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Directories

            SchoolDirectory StoryBrookHighDirectory = new SchoolDirectory()
            {

            };

            DirectoryBST StoryBrookHighGradeDirectory = new DirectoryBST();

            #endregion Directories

            #region School Classes

            SchoolClass Alpha6 = new SchoolClass()
            {
                ClassID = "20",
                Name = "Six Alpha",
                NumberOfStudents = 4,
                TeacherName = "Barbara Barker",
                TeacherID = "10"
            };

            SchoolClass Bravo6 = new SchoolClass()
            {
                ClassID = "21",
                Name = "Six Bravo",
                NumberOfStudents = 4,
                TeacherName = "Tony Johnson",
                TeacherID = "11"
            };

            SchoolClass Charlie6 = new SchoolClass()
            {
                ClassID = "22",
                Name = "Six Charlie",
                NumberOfStudents = 4,
                TeacherName = "Sarah Pink",
                TeacherID = "12"
            };

            StoryBrookHighDirectory.SchoolClasses.Add(Alpha6);
            StoryBrookHighDirectory.SchoolClasses.Add(Bravo6);
            StoryBrookHighDirectory.SchoolClasses.Add(Charlie6);

            #endregion School Classes

            #region Teachers

            Teacher MrsBarker = new Teacher()
            {
                ClassName = "Six Alpha",
                TeacherName = "Barbara Barker",
                TeacherID = "10",
            };
            Teacher MrJohnson = new Teacher()
            {
                ClassName = "Six Bravo",
                TeacherName = "Tony Johnson",
                TeacherID = "11",
            };
            Teacher MsPink = new Teacher()
            {
                ClassName = "Six Charlie",
                TeacherName = "Sarah Pink",
                TeacherID = "12",
            };

            StoryBrookHighDirectory.SchoolTeachers.Add(MsPink);
            StoryBrookHighDirectory.SchoolTeachers.Add(MrsBarker);
            StoryBrookHighDirectory.SchoolTeachers.Add(MrJohnson);

            #endregion Teachers

            #region Students

            #region Six Alpha Students

            Student Zachary = new Student()
            {
                FirstName = "Zachary",
                MiddleInitial = "R",
                LastName = "Bailey",
                Age = 29,
                StudentID = "1",
                TeacherID = "10",
                ClassID = "20"
            };

            Student Chelsea = new Student()
            {
                FirstName = "Chelsea",
                MiddleInitial = "W",
                LastName = "Chels",
                Age = 21,
                StudentID = "2",
                TeacherID = "10",
                ClassID = "20"
            };

            Student Jackie = new Student()
            {
                FirstName = "Jackie",
                MiddleInitial = "B",
                LastName = "Redding",
                Age = 25,
                StudentID = "3",
                TeacherID = "10",
                ClassID = "20"
            };

            Student Brian = new Student()
            {
                FirstName = "Brian",
                MiddleInitial = "T",
                LastName = "Donlin",
                Age = 43,
                StudentID = "4",
                TeacherID = "10",
                ClassID = "20"
            };

            MrsBarker.classStudents.Add(Zachary);
            MrsBarker.classStudents.Add(Chelsea);
            MrsBarker.classStudents.Add(Jackie);
            MrsBarker.classStudents.Add(Brian);

            #endregion Six Alpha Students

            #region Six Bravo Students

            Student Greg = new Student()
            {
                FirstName = "Greg",
                MiddleInitial = "C",
                LastName = "Bonlet",
                Age = 23,
                StudentID = "5",
                TeacherID = "11",
                ClassID = "21"
            };

            Student Kathryn = new Student()
            {
                FirstName = "Kathryn",
                MiddleInitial = "M",
                LastName = "Williet",
                Age = 20,
                StudentID = "6",
                TeacherID = "11",
                ClassID = "21"
            };

            Student Erin = new Student()
            {
                FirstName = "Erin",
                MiddleInitial = "M",
                LastName = "Blu",
                Age = 27,
                StudentID = "7",
                TeacherID = "11",
                ClassID = "21"
            };

            Student Lia = new Student()
            {
                FirstName = "Lia",
                MiddleInitial = "O",
                LastName = "Contreras",
                Age = 34,
                StudentID = "8",
                TeacherID = "11",
                ClassID = "21"
            };

            MrJohnson.classStudents.Add(Greg);
            MrJohnson.classStudents.Add(Kathryn);
            MrJohnson.classStudents.Add(Erin);
            MrJohnson.classStudents.Add(Lia);

            #endregion Six Bravo Students

            #region Six Charlie Students

            Student Barry = new Student()
            {
                FirstName = "Barry",
                MiddleInitial = "B",
                LastName = "Bear",
                Age = 30,
                StudentID = "0",
                TeacherID = "12",
                ClassID = "22"
            };

            Student Frank = new Student()
            {
                FirstName = "Frank",
                MiddleInitial = "C",
                LastName = "Derney",
                Age = 32,
                StudentID = "9",
                TeacherID = "12",
                ClassID = "22"
            };

            Student Clara = new Student()
            {
                FirstName = "Clara",
                MiddleInitial = "Z",
                LastName = "Clons",
                Age = 25,
                StudentID = "50",
                TeacherID = "12",
                ClassID = "22"
            };

            Student Isabella = new Student()
            {
                FirstName = "Isabella",
                MiddleInitial = "N",
                LastName = "Hunt",
                Age = 37,
                StudentID = "51",
                TeacherID = "12",
                ClassID = "22"
            };

            MsPink.classStudents.Add(Barry);
            MsPink.classStudents.Add(Clara);
            MsPink.classStudents.Add(Isabella);
            MsPink.classStudents.Add(Frank);

            #endregion Six CHarlie Students

            //Apha6
            StoryBrookHighDirectory.SchoolStudents.Add(Zachary);
            StoryBrookHighDirectory.SchoolStudents.Add(Chelsea);
            StoryBrookHighDirectory.SchoolStudents.Add(Jackie);
            StoryBrookHighDirectory.SchoolStudents.Add(Brian);

            Alpha6.Students.Add(Zachary);
            Alpha6.Students.Add(Chelsea);
            Alpha6.Students.Add(Jackie);
            Alpha6.Students.Add(Brian);

            MrsBarker.classStudents.Add(Zachary);
            MrsBarker.classStudents.Add(Chelsea);
            MrsBarker.classStudents.Add(Jackie);
            MrsBarker.classStudents.Add(Brian);

            //Bravo6
            StoryBrookHighDirectory.SchoolStudents.Add(Greg);
            StoryBrookHighDirectory.SchoolStudents.Add(Kathryn);
            StoryBrookHighDirectory.SchoolStudents.Add(Erin);
            StoryBrookHighDirectory.SchoolStudents.Add(Lia);

            Bravo6.Students.Add(Greg);
            Bravo6.Students.Add(Kathryn);
            Bravo6.Students.Add(Erin);
            Bravo6.Students.Add(Lia);

            MrJohnson.classStudents.Add(Greg);
            MrJohnson.classStudents.Add(Kathryn);
            MrJohnson.classStudents.Add(Erin);
            MrJohnson.classStudents.Add(Lia);


            //Charlie6
            StoryBrookHighDirectory.SchoolStudents.Add(Barry);
            StoryBrookHighDirectory.SchoolStudents.Add(Frank);
            StoryBrookHighDirectory.SchoolStudents.Add(Clara);
            StoryBrookHighDirectory.SchoolStudents.Add(Isabella);

            Charlie6.Students.Add(Barry);
            Charlie6.Students.Add(Frank);
            Charlie6.Students.Add(Clara);
            Charlie6.Students.Add(Isabella);

            MsPink.classStudents.Add(Barry);
            MsPink.classStudents.Add(Frank);
            MsPink.classStudents.Add(Clara);
            MsPink.classStudents.Add(Isabella);


            #endregion Students

            #region CreateGrades

            AssigningGrades.AssignStudentGrades(StoryBrookHighDirectory);
            foreach (SchoolClass schoolclass in StoryBrookHighDirectory.SchoolClasses)
            {
                CalculateClassGPA.ClassGPACalc(schoolclass);
            }
            foreach (Teacher teacher in StoryBrookHighDirectory.SchoolTeachers)
            {
                foreach (SchoolClass sch in StoryBrookHighDirectory.SchoolClasses)
                {
                    if (teacher.TeacherID == sch.TeacherID)
                    {
                        teacher.ClassGPA = sch.OverallClassGPA;
                    }
                }
            }

            #endregion CreateGrades

            #region Sorting Data

            FindHighestGrades.SortHighestClass(StoryBrookHighDirectory);
            FindHighestGrades.SortHighest(StoryBrookHighDirectory.SchoolStudents);

            #endregion Sorting Data

            #region Program Start

            Menu menu = new Menu();
            Console.CursorVisible = false;
            int selectedIndex = menu.RunMainMenu(); ;
            while (menu != null)
            {
                if (selectedIndex == 0)
                {
                    menu.ViewClasses(StoryBrookHighDirectory);
                    break;
                }
                else if (selectedIndex == 1)
                {
                    menu.ViewTeachers(StoryBrookHighDirectory);
                    break;
                }
                else if (selectedIndex == 2)
                {
                    menu.ViewStudents(StoryBrookHighDirectory);
                    break;
                }
                else if (selectedIndex == 3)
                {
                    SchoolClass.AddClass(StoryBrookHighDirectory);
                }
                else if (selectedIndex == 4)
                {
                    Student.AddStudent(StoryBrookHighDirectory);           
                }
                else if (selectedIndex == 5)
                {
                    
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the gradebook!");
                    Console.WriteLine();
                    Environment.Exit(0);
                }
                else if (selectedIndex == 30)
                {
                    Environment.Exit(0);
                }
            }

            #endregion Program Start

        }

        #region Menu Class

        public class Menu
        {
            private int SelectedIndex;
            public List<string> Options;
            public string MenuTitle;

            public Menu()
            {

            }
            public Menu(string menutitle, List<string> options)
            {
                Options = options;
                MenuTitle = menutitle;
                SelectedIndex = 0;
            }

            public int RunMainMenu()
            {
                string menutitle = "Welcome to StoryBrook High GradeBook!";
                List<string> mainMenuOptions = new List<string>() { "View Classes", "View Teachers", "View Students", "Add Class", "Add Student", "Exit"};
                Menu mainMenu = new Menu(menutitle, mainMenuOptions);
                SelectedIndex = mainMenu.RunMenu();

                return SelectedIndex;
            }

            #region Standard Menu Logic
            private void DisplayMenu()
            {
                Console.WriteLine($"{MenuTitle}");
                Console.WriteLine();
                for (int i = 0; i < Options.Count; i++)
                {
                    string selectedOption = Options[i];
                    string onThis;

                    if (i == SelectedIndex)
                    {
                        onThis = "*";
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        onThis = " ";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine($"{onThis}{selectedOption}");
                }
                Console.ResetColor();
            }

            public int RunMenu()
            {
                ConsoleKey keyPress;
                do
                {
                    Console.Clear();
                    DisplayMenu();

                    ConsoleKeyInfo currentKey = Console.ReadKey(true);
                    keyPress = currentKey.Key;

                    if (keyPress == ConsoleKey.UpArrow)
                    {
                        SelectedIndex--;
                        if (SelectedIndex == -1)
                        {
                            SelectedIndex = Options.Count - 1;
                        }
                    }
                    else if (keyPress == ConsoleKey.DownArrow)
                    {
                        SelectedIndex++;
                        if (SelectedIndex == Options.Count)
                        {
                            SelectedIndex = 0;
                        }
                    }
                    else if (keyPress == ConsoleKey.Backspace)
                    {
                        SelectedIndex = 30;
                        return SelectedIndex;
                    }

                } while (keyPress != ConsoleKey.Enter);

                return SelectedIndex;
            }

            #endregion Standard Menu Logic

            #region View Classes

            public void ViewClasses(SchoolDirectory thisDirectory)
            {
                string menutitle = "Please see our list of classes: ";
                List<string> classesMenu = new List<string>();
                foreach (SchoolClass schoolclass in thisDirectory.SchoolClasses)
                {
                    classesMenu.Add(schoolclass.Name);
                }
                Menu viewClassesMenu = new Menu(menutitle, classesMenu);
                int selectedIndex1 = viewClassesMenu.RunMenu();

                switch (selectedIndex1)
                {
                    case 0:
                        int theAnswer2;
                        foreach (SchoolClass schoolclass in thisDirectory.SchoolClasses)
                        {
                            if (schoolclass.Name == classesMenu[selectedIndex1])
                            {
                                SchoolClass thisClass = schoolclass;
                                Console.Clear();
                                do
                                {
                                    theAnswer2 = ClassDetails.DisplayClassStats(thisClass);
                                }
                                while (theAnswer2 != 0);
                                switch (theAnswer2)
                                {
                                    case 0:
                                        ViewClasses(thisDirectory);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    case 1:
                        int theAnswer1;
                        foreach (SchoolClass schoolclass in thisDirectory.SchoolClasses)
                        {
                            if (schoolclass.Name == classesMenu[selectedIndex1])
                            {
                                SchoolClass thisClass = schoolclass;
                                Console.Clear();
                                do
                                {
                                    theAnswer1 = ClassDetails.DisplayClassStats(thisClass);
                                }
                                while (theAnswer1 != 0);
                                switch (theAnswer1)
                                {
                                    case 0:
                                        ViewClasses(thisDirectory);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    case 2:
                        int theAnswer;
                        foreach (SchoolClass schoolclass in thisDirectory.SchoolClasses)
                        {
                            if (schoolclass.Name == classesMenu[selectedIndex1])
                            {
                                SchoolClass thisClass = schoolclass;
                                Console.Clear();
                                do
                                {
                                    theAnswer = ClassDetails.DisplayClassStats(thisClass);
                                }
                                while (theAnswer != 0);
                                switch (theAnswer)
                                {
                                    case 0:
                                        ViewClasses(thisDirectory);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    default:
                        int theAnswer10;
                        foreach (SchoolClass schoolclass in thisDirectory.SchoolClasses)
                        {
                            if (schoolclass.Name == classesMenu[selectedIndex1])
                            {
                                SchoolClass thisClass = schoolclass;
                                Console.Clear();
                                do
                                {
                                    theAnswer10 = ClassDetails.DisplayClassStats(thisClass);
                                }
                                while (theAnswer10 != 0);
                                switch (theAnswer10)
                                {
                                    case 0:
                                        ViewClasses(thisDirectory);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    case 30:
                        int thisSelectedIndex = RunMainMenu();

                        if (thisSelectedIndex == 0)
                        {
                            Menu menuThis = new Menu();
                            menuThis.ViewClasses(thisDirectory);
                            break;
                        }
                        else if (thisSelectedIndex == 1)
                        {
                            Menu menuThis = new Menu();
                            menuThis.ViewTeachers(thisDirectory);
                            break;
                        }
                        else if (thisSelectedIndex == 2)
                        {
                            Menu menuThis = new Menu();
                            menuThis.ViewStudents(thisDirectory);
                            break;
                        }
                        else if (thisSelectedIndex == 3)
                        {
                            SchoolClass.AddClass(thisDirectory);
                        }
                        else if (thisSelectedIndex == 4)
                        {
                            Student.AddStudent(thisDirectory);
                        }
                        else if (thisSelectedIndex == 30)
                        {
                            break;
                        }
                        break;
                }
            }

            #endregion View Classes

            #region View Teachers

            public void ViewTeachers(SchoolDirectory thisDirectory)
            {
                string menutitle = "Please see our list of teachers below: ";
                List<string> teachersMenu = new List<string>();
                foreach (Teacher teachers in thisDirectory.SchoolTeachers)
                {
                    teachersMenu.Add(teachers.TeacherName);
                }
                Menu viewTeachersMenu = new Menu(menutitle, teachersMenu);
                int selectedIndex2 = viewTeachersMenu.RunMenu();

                switch (selectedIndex2)
                {
                    case 0:
                        int theAnswer2;
                        foreach (Teacher teachers in thisDirectory.SchoolTeachers)
                        {
                            if (teachers.TeacherName == teachersMenu[selectedIndex2])
                            {
                                Teacher thisTeacher = teachers;
                                Console.Clear();
                                do
                                {
                                    theAnswer2 = TeacherDetails.DisplayTeacherStats(teachers);
                                }
                                while (theAnswer2 != 0);
                                switch (theAnswer2)
                                {
                                    case 0:
                                        ViewTeachers(thisDirectory);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    case 1:
                        int theAnswer3;
                        foreach (Teacher teachers in thisDirectory.SchoolTeachers)
                        {
                            if (teachers.TeacherName == teachersMenu[selectedIndex2])
                            {
                                Teacher thisTeacher = teachers;
                                Console.Clear();
                                do
                                {
                                    theAnswer3 = TeacherDetails.DisplayTeacherStats(teachers);
                                }
                                while (theAnswer3 != 0);
                                switch (theAnswer3)
                                {
                                    case 0:
                                        ViewTeachers(thisDirectory);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    case 2:
                        int theAnswer4;
                        foreach (Teacher teachers in thisDirectory.SchoolTeachers)
                        {
                            if (teachers.TeacherName == teachersMenu[selectedIndex2])
                            {
                                Teacher thisTeacher = teachers;
                                Console.Clear();
                                do
                                {
                                    theAnswer4 = TeacherDetails.DisplayTeacherStats(teachers);
                                }
                                while (theAnswer4 != 0);
                                switch (theAnswer4)
                                {
                                    case 0:
                                        ViewTeachers(thisDirectory);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                    case 30:
                        int thisSelectedIndex = RunMainMenu();

                        if (thisSelectedIndex == 0)
                        {
                            Menu menuThis = new Menu();
                            menuThis.ViewClasses(thisDirectory);
                            break;
                        }
                        else if (thisSelectedIndex == 1)
                        {
                            Menu menuThis = new Menu();
                            menuThis.ViewTeachers(thisDirectory);
                            break;
                        }
                        else if (thisSelectedIndex == 2)
                        {
                            Menu menuThis = new Menu();
                            menuThis.ViewStudents(thisDirectory);
                            break;
                        }
                        else if (thisSelectedIndex == 3)
                        {
                            SchoolClass.AddClass(thisDirectory);
                        }
                        else if (thisSelectedIndex == 4)
                        {
                            Student.AddStudent(thisDirectory);
                        }
                        else if (thisSelectedIndex == 30)
                        {
                            break;
                        }
                        break;
                }
            }

            #endregion View Teachers

            #region View Students

            public void ViewStudents(SchoolDirectory thisDirectory)
            {
                string menutitle = "Please see our list of students below: ";
                List<string> studentsMenu = new List<string>();
                foreach (Student students in thisDirectory.SchoolStudents)
                {
                    studentsMenu.Add($"{students.LastName}, {students.FirstName}. {students.MiddleInitial}.");
                }
                Menu viewStudentsMenu = new Menu(menutitle, studentsMenu);
                int selectedIndex = viewStudentsMenu.RunMenu();

                switch (selectedIndex)
                {
                    case 30:
                        int thisSelectedIndex = RunMainMenu();

                        if (thisSelectedIndex == 0)
                        {
                            Menu menuThis = new Menu();
                            menuThis.ViewClasses(thisDirectory);
                            break;
                        }
                        else if (thisSelectedIndex == 1)
                        {
                            Menu menuThis = new Menu();
                            menuThis.ViewTeachers(thisDirectory);
                            break;
                        }
                        else if (thisSelectedIndex == 2)
                        {
                            Menu menuThis = new Menu();
                            menuThis.ViewStudents(thisDirectory);
                            break;
                        }
                        else if (thisSelectedIndex == 3)
                        {
                            SchoolClass.AddClass(thisDirectory);
                        }
                        else if (thisSelectedIndex == 4)
                        {
                            Student.AddStudent(thisDirectory);
                        }
                        else if (thisSelectedIndex == 30)
                        {
                            break;
                        }
                        break;
                    default:
                        int theAnswer5;
                        foreach (Student students in thisDirectory.SchoolStudents)
                        {
                            if ($"{students.LastName}, {students.FirstName}. {students.MiddleInitial}." == studentsMenu[selectedIndex])
                            {
                                Student thisStudent = students;
                                Console.Clear();
                                do
                                {
                                    theAnswer5 = DisplayStudentDetails.DisplayStudentStats(students);
                                }
                                while (theAnswer5 != 0);
                                switch (theAnswer5)
                                {
                                    case 0:
                                        ViewStudents(thisDirectory);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
            #endregion View Students

        }

        #endregion Menu Class
    }
}
