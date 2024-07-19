//anonymous types

using NewCohort;

var subject = new { Name = "tolu", age = 345 };

Console.WriteLine(subject.age + "  "+ subject.Name);

var person = new { age = 50, name = "maadey", status = "married" };
Console.WriteLine(person);

var school = new
{
    name = "ada",
    dept = "ss1",
    Employee = new { age = 50, level = 200 }
};

Console.WriteLine(school.Employee.level);

//extensions method
int x = 20;

var result = x.IsGreaterThan(50);
Console.WriteLine(result);
