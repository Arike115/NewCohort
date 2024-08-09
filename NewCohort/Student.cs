using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCohort
{
    public  class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public int SntdId { get; set; }

    }

    public class Standard
    { 
       public int StandardId {  get; set; }
        public string StandardName {  get; set; }
    
    }

}
