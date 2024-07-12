using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NewCohort
{
    public class Student : ISchool
    {
        public static string Name;
        public static int Age;

      

        string ISchool.Name => throw new NotImplementedException();

        public static void StudentDetails()
        {
            Name = "Ben";
            Age = 12;
            Console.WriteLine("my name is {0}, and i'm {1} years old",Name, Age);
        }

        public void Departmments()
        {
            Console.WriteLine("the chemistry department is the best so far ");
        }

        public void Faculty()
        {
            Console.WriteLine("the Media faculty is trending");
        }
    }



   

}
