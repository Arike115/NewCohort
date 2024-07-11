//Relationaloperators
//==
//!=
//> <
//>= =<

//logical operators
//&&
//||
//!
//statement
//conditional statement
//if&if-else
//switch case
double v = 89.90;
double x = 20.50;

string word = "chalk";
string data = "chalk";

if(word == data ||  x > v)
{
    Console.WriteLine("they are equal");
}
else
{
    Console.WriteLine("they are not equal");
}


if (v >= x)
    Console.WriteLine("we have greater values here");
else
    Console.WriteLine("we do not have higher values here ");


//switch case
int day = 6;

switch (day)
{ 

    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
        default: 
        Console.WriteLine("not on the list");
        break;

}

