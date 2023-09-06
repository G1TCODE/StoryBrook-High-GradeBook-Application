using StoryBrook_High_GradeBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryBrook_High_GradeBook.Services;

namespace StoryBrook_High_GradeBook.Data
{
    public class DataCreation
    {
        public SchoolDirectory StoryBrookHighDirectory = new SchoolDirectory();

        public DirectoryBST StoryBrookHighGradeDirectory = new DirectoryBST();
        public void CreateData()
        {
            #region Directories

            SchoolDirectory StoryBrookHighDirectory = new SchoolDirectory();

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

            FindHighestGrades.SortHighestClass(StoryBrookHighDirectory);
            FindHighestGrades.SortHighest(StoryBrookHighDirectory.SchoolStudents);
        }
    }
}