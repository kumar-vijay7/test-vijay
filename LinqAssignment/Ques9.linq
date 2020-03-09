<Query Kind="Statements" />

IList<string> EmpList=new List<string>(){"vijay","vishesh","Abhishek"};
var d_empty=EmpList.DefaultIfEmpty();
Console.WriteLine(d_empty);