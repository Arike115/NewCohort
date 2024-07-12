//inheritance
using NewCohort;
//escape sequence
//\"
//\'
//\\

//Console.WriteLine("the new generation\b will make the world a bigger place");

//Employee employee = new Employee();
//employee.Faculty();
//employee.Departmments();


//const int v = 56;
//int x = 23;

//Console.WriteLine("what days of the week is today");
//var  result = Console.ReadLine();


DateTime todaydate = DateTime.Now;
Console.WriteLine(todaydate);



var value = DaysOfTheWeek.Friday;
switch (value)
{
    case DaysOfTheWeek.Monday:
        Console.WriteLine("values is not correct");
        break;
    case DaysOfTheWeek.Tuesday:
        Console.WriteLine("value is not correct");
        break;
    case DaysOfTheWeek.Wednesday:
        Console.WriteLine("value is not correct");
        break;
    case DaysOfTheWeek.Thursday:
        Console.WriteLine("value is not correct");
        break;
    case DaysOfTheWeek.Friday:
        Console.WriteLine("value is correct");
        break;
        default:
        Console.WriteLine("the value does not exist");
        break;








}





