using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCohort
{
    public interface ISchool 
    {
        string Name { get; }    

       void Departmments();
       void Faculty();

    }

    public interface Iward
    { }

    public interface IStudent
    { }
}
