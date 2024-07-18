//Exceptionhandling
//try,catch,finally

try
{
    int[] mynumber = { 2, 3, 4, 5, 6, 7 };
    Console.WriteLine(mynumber[10]);
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}


int age = 19;

if(age < 20)
{
    throw new ArithmeticException("Access denied -  you must be 20 and above");
}
else
{
    Console.WriteLine("Access granted");
}

Console.ReadKey();