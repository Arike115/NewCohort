using NewCohort;
//delegate


//HelloDelegate del = new HelloDelegate(Introduction);
//del("welcome to delegate class");



//static void Introduction(string message)
//{
//    Console.WriteLine(message);
//}

List<Employee> emplist = new List<Employee>();

emplist.Add(new Employee() { Id = 1 , Name = "Tolu", Salary =  150000, Experience =  1});
emplist.Add(new Employee() { Id = 2, Name = "Ben", Salary = 120000, Experience = 2 });
emplist.Add(new Employee() { Id = 3, Name = "Joy", Salary = 200000, Experience = 7 });
emplist.Add(new Employee() { Id = 4, Name = "Grace", Salary = 250000, Experience = 6 });
emplist.Add(new Employee() { Id = 5, Name = "Fola", Salary = 350000, Experience = 5 });
emplist.Add(new Employee() { Id = 6, Name = "Ada", Salary = 190000, Experience = 5 });

//IsPromotable isPromotable = new IsPromotable(promotemethod);

Employee.PromoteStaff(emplist, y => y.Salary < 2000); //=> lamdba expression

Console.WriteLine("*************experience******************");

//IsPromotable promo = new IsPromotable(experiencemethod);

Employee.PromoteStaff(emplist, emp => emp.Experience >= 2);


//bool promotemethod(Employee staff)
//{
//    if(staff.Salary < 200000)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}


bool experiencemethod(Employee emp)
{
    if (emp.Experience >= 2)
        return true;
    else
        return false;
}


Console.ReadKey();




