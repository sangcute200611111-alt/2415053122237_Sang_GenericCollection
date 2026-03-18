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
            Console.WriteLine($"{info} | Bài 12");
            List<Student> ds = new List<Student> {
                new Student { Id = 1, Name = "Sang" },
                new Student { Id = 2, Name = "An" }
            };
            Console.Write("Nhập tên sinh viên cần tìm: ");
            string search = Console.ReadLine();
            var sv = ds.Find(s => s.Name.Equals(search, StringComparison.OrdinalIgnoreCase));
            if (sv != null) Console.WriteLine($"Tìm thấy sinh viên ID: {sv.Id}");
            else Console.WriteLine("Không tìm thấy sinh viên này.");
            Console.ReadKey();
        }
    }
}