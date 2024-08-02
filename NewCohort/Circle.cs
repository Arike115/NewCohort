using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCohort
{
    public abstract class Circle
    {
        int v = 6;
        public string name { get; set; }
        public abstract void AreaOfAcircle();
        public void Radius()
        {
            Console.WriteLine("this is radius");
        }
    }
}
