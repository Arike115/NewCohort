using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCohort
{
    //delegate
    public delegate bool IsPromotable(Employee m);

    //class
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience  { get; set; }


        public static void  PromoteStaff (List<Employee> stafflist, IsPromotable EligibleToPromote)
        {
            foreach(var emp in stafflist)
            {
                if(EligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name +" " +" is promoted");
                }
                else
                {
                    Console.WriteLine(emp.Name + " " + "not promoted");
                }
            }
        }
    }

  

}
