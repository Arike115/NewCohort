using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCohort
{
    //customise
    //obsolete
    //web method
    //serialization
    //nonserializtion

    public class Triangle : Circle
    {
        public override void AreaOfAcircle()
        {
            Console.WriteLine("this area is triangle not circle");
        }

        [Obsolete]
        public void Breadth()
        {

        }

        public void Breadth(int i, int y, int v)
        {

        }

        public void Breadth(int x)
        { 
        }
    }
}
