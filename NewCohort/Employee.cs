using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCohort
{
    public class Employee : Student
    {
        public static string TeacherName;
        public static int level;

        public static void TeacherDetails()
        {
            TeacherName = "Ivan Grace";
            level = 200;
            Console.WriteLine("The teacher name is {0}, she takes chemitry class in {1} level", TeacherName,level);
        }

        public static void ClassRep(string name)
        {
            Console.WriteLine("the class rep name is" + name);
        }
    }
}
