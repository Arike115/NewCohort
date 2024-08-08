//linq
//language integrated query
//filtering  : where
//sorting operators : orderby, orderbydescending, thenby, thenbydescending
//setOperators : Distinct, union, intersect,except,concat
//aggregatefunction : average,sum,max,min,count,aggregate
//elementOperators : first, firstordefault, last, lastordefault,elementat, elementordefault, single, singleordefault

using NewCohort;
using System.Globalization;

//filtering and setoperators
int[] number = { 6, 8, 4, 2, 10, 16, 18, 14, 12 };

// query syntax
var result = from n in number where n > 4 orderby n descending select n;
foreach (var y in result)
{
    Console.WriteLine(y);
}

List<Student> studentlist = new List<Student>() {

new Student() { Id = 101, Name = "Lade", Age = 25},
new Student() { Id = 102, Name = "Lade", Age = 20 },
new Student() { Id = 103, Name = "Dolapo", Age = 21 },
new Student() { Id = 104, Name = "Ben", Age = 75},
new Student() { Id = 105, Name = "Joe", Age = 15},

};

//sorting Operators
//method sytax
var data = studentlist.OrderBy(s => s.Name).ThenBy(r => r.Age);

 foreach (var y in data)
{
    Console.WriteLine(y.Name +" "+ y.Age);
}

//set Operators

int[] value1 = { 3, 4, 5, 6, 7, 8, 9, 2, 10, 2, 10, 4, 3 };
int[] value2 = { 2, 4, 6, 8, 10, 12, 1, 4, 16, 18, 20 };

var distinctmethod = value1.Distinct();
Console.WriteLine("Distinct:" + String.Join(",",distinctmethod) );

var unionmethod = value1.Union(value2);
Console.WriteLine("Union:" + String.Join(",", unionmethod));

var intersectmethod = value1.Intersect(value2);
Console.WriteLine("intersect:" + String.Join(",", intersectmethod));

var exceptmethod = value1.Except(value2);
Console.WriteLine("except:" + String.Join(",", exceptmethod));

var Concatmethod = value1.Concat(value2);
Console.WriteLine("Concat:" + String.Join(",", Concatmethod));


//Aggregate function
var sumvalue = number.Sum();
Console.WriteLine("Sum" + sumvalue);
var minvalue = number.Min();
Console.WriteLine("min" + minvalue);
var maxvalue = number.Max();
Console.WriteLine("max" + maxvalue);
var avaragevalue = number.Average();
Console.WriteLine("avarage" + avaragevalue);
var aggregatevalue = number.Aggregate((s,r) => (s *r) );
Console.WriteLine(aggregatevalue);

int[] value3 = { };

var finalresult = value1.ElementAtOrDefault(3);
Console.WriteLine(finalresult);