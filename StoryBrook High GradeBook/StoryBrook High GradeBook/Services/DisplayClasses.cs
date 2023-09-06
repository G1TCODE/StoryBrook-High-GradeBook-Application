using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBrook_High_GradeBook.Services
{
    public static class DisplayClasses
    {
        public static void DisplayAllClasses(SchoolDirectory thisDirectory)
        {
            foreach(SchoolClass schoolclass in thisDirectory.SchoolClasses)
            {
                Console.WriteLine($"{schoolclass.Name}");
            }
        }
    }
}
