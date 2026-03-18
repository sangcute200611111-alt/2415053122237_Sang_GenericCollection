using System;
using System.Collections.Generic;
using System.Text;

namespace BT_GenericCollection
{
    public class Student { public int Id; public string Name; }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 11");
            List<Student> ds = new List<Student> {
                new Student { Id = 1, Name = "Võ Văn Sang" },
                new Student { Id = 2, Name = "Nguyễn Văn An" }
            };
            foreach (var s in ds) Console.WriteLine($"ID: {s.Id} - Tên: {s.Name}");
            Console.ReadKey();
        }
    }
}