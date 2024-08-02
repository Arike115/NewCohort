//stack -- first out - last out
//queue --- first out-first out
//dictionary
Dictionary<string, string> staffList = new Dictionary<string, string>();

staffList.Add("Ben","Manager");
staffList.Add("Grace", "Analyst");
staffList.Add("Joy", "Programmer");
staffList.Add("Ken", "It");
staffList.Add("Lola", "Marketer");

//foreach (var item in staffList)
//{
//    Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);

//}


//queue(first in -first out)

Queue<int> queue = new Queue<int>();  

queue.Enqueue(41);
queue.Enqueue(15);
queue.Enqueue(19);
queue.Enqueue(21);
queue.Enqueue(1);

//var data = queue.Dequeue();
//Console.WriteLine(data);

//var datas =  queue.Dequeue();
//Console.WriteLine(datas);

Stack<decimal> stacklist = new Stack<decimal>();
stacklist.Push(7.89m);
stacklist.Push(90);
stacklist.Push(45.7m);
stacklist.Push(111);
stacklist.Push(01927.89m);
Console.WriteLine("Number of element in stack : {0}", stacklist.Count());
while (stacklist.Count > 0)
{
    Console.WriteLine(stacklist.Pop() + ", ");
}
Console.WriteLine("Number of element in stack : {0}", stacklist.Count());