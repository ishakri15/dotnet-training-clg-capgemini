using System.Collections;

namespace NonGenericSortedList;

class Program
{
    static void Main(string[] args)
    {
        SortedList students = new SortedList();
        students.Add(101,"Alice");
        students.Add(102,"Bob");
        students.Add(105,"Charlie");
        students.Add(104,"David");
        students.Add(103,"Eve");
        foreach (DictionaryEntry entry in students)
        {
            Console.WriteLine($"Student id : {entry.Key} and Student name : {entry.Value}");
        }
        Console.ReadLine();
    }
}
