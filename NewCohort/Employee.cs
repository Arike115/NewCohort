using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCohort
{
  

    /// <summary>
    /// /this class is for extension method
    /// </summary>
    public static class Employee
    {

        /// <summary>
        /// 
        /// </summary>
        public static string Name { get; set; }
        /// <summary>
        /// this method is an extension method for integer
        /// </summary>
        /// <param name="i"></param>
        /// <param name="v"></param>
        /// <returns>bool</returns>
        public static bool IsGreaterThan(this int i , int v) //extension method
        {
            return i > v;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public static void VoidMethod()
        { 
        }
    }

  

}
