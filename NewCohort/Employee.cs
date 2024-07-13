using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCohort
{
    public class Employee<P>
    {
       
        public static void ClassRep(P name)
        {
            Console.WriteLine("the class rep name is" + name);
        }

        public void Departmments()
        {
            Console.WriteLine();
        }

       
    }

  

}
