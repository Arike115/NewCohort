//linq
//quanitifiers : any,all, contain
//joining : innerjoin, leftjoin, rightjoin, outerjoin
//Grouping

//Quantifiers
//any,all,container
using NewCohort;
using NewCohort.Loccation;

List<Student> studentlist = new List<Student>() {
    new Student() { Id = 101 , Name = "fola", Age = 19, SntdId =2},
    new Student() { Id = 102, Name = "ola", Age = 15, SntdId = 3},
    new Student() { Id = 103 , Name = "deji", Age = 20, SntdId = 4},
    new Student() { Id = 104 , Name = "ben", Age = 17, SntdId = 2},
    new Student() { Id = 105 , Name = "shola", Age = 16, SntdId = 3},
     new Student() { Id = 106 , Name = "joy", Age = 16},
};

List<Standard> stndlist = new List<Standard>()
{ 
    new Standard() {StandardId = 1, StandardName = "Beginner level"},
    new Standard() {StandardId = 2, StandardName = "Junior level"},
    new Standard() {StandardId = 3, StandardName = "Senior level"},
    new Standard() {StandardId = 4, StandardName = "Expert"}
};


//innerjoin,join
//query syntax
var result = from stud in studentlist
             join stnd in stndlist
             on stud.SntdId equals stnd.StandardId
             select new { stud.Name, stnd.StandardName };

//method syntax
var results = studentlist .Join
               (stndlist,
               stud => stud.SntdId,
               stnd => stnd.StandardId,
               (stud,stnd) => new 
               {
                stud.Name,
                stnd.StandardName,
               }).ToList();


foreach(var item in results)
{
    Console.WriteLine($"Name: {item.Name}, StandardName:  {item.StandardName}");
}

Console.WriteLine("****************leftjoin*****************");
//left join , left outerjoin
var leftjoin = from stud in studentlist //left
               join stnd in stndlist //right
               on stud.SntdId equals stnd.StandardId
               into studnetgroup
               from sud in studnetgroup.DefaultIfEmpty()
               select new {
                   stud.Name, 
                   stud.Id, 
                   sud};

foreach (var item in leftjoin)
{
    Console.WriteLine($"Name: {item.Name}, StandardName:  {item.sud?.StandardName}, Id: {item.Id}");
}




//var data = studentlist.Any(x => x.Age == 10 & x.Age > 15);
//Console.WriteLine(data);
//var datas = studentlist.All(x =>  x.Age == 15);
//Console.WriteLine(datas) ;
//var dates = studentlist.Contains(x => x);
//Console.WriteLine(dates);