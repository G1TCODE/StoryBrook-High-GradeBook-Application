using System;

public class Class1
{
	public static Class1()
	{
        public void AssignStudentGrades()
        {
            Random rnd = new Random();

            foreach (Student student in StoryBrookHighDirectory.SchoolStudents)
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
