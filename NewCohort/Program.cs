//Loops
//while
//do/while
//for
//foreach

//while

using NewCohort;

int v = 0;
while(v < 10)
{
    Console.WriteLine(v);
    v++;
}

Console.WriteLine("******************************");
//do/while

int i  = 0;

do
{
    Console.WriteLine(i);
    i++;
}
while(i < 10);



Console.WriteLine("*******************FOR**************************");
//for

for (int x = 0; x < 20; x+=2)
{
    Console.WriteLine(x);
}


//static values
Employee.Calculator();

Student.Result();

//non-static
Student student = new Student();
student.Result1();


Console.ReadKey();