//icollection
//ilist
//ienumerable
//list

List<string> Wears = new List<string>();
Wears.Add("Skirt");
Wears.Add("Trouser");
Wears.Add("Short");
Wears.Add("Shirt");
Wears.Add("Singlet");
Wears.Add("Blouse");

collectionDisplay(Wears);
IlistDisplay(Wears);
ListDisplay(Wears);
IenumerableDisplay(Wears);

static void collectionDisplay(ICollection<string> mylist)
{
     
    mylist.Add("Jumpsuite");
    foreach (var item in mylist)
        Console.WriteLine("icollection display" + " " +item);
    Console.WriteLine("*************************");
}

static void IlistDisplay(IList<string> mylist)
{
    mylist.Insert(3, "joggers");
    mylist.Add("cargo pant");
    foreach (var item in mylist)
        Console.WriteLine("ilistdiplay display" + " " + item);
    Console.WriteLine("*************************");
}

static void ListDisplay(List<string> mylist)
{

    mylist.Insert(2, "polo");
    mylist.Add("jeans");
    mylist.Sort();
    
    foreach (var item in mylist)
        Console.WriteLine("listdiplay display" + " " + item);
    Console.WriteLine("*************************");
}

static void IenumerableDisplay(IEnumerable<string> mylist)
{
    var data = mylist.First();
    Console.WriteLine("ienumerable" + " " + data);
}