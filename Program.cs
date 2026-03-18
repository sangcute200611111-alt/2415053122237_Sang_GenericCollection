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
                new Student { Id = 2, Name = "An" },
                new Student { Id = 3, Name = "Bình" }
            };

            Console.WriteLine("Danh sách sinh viên hiện có:");
            foreach (var s in ds)
            {
                Console.WriteLine($"- ID: {s.Id}, Tên: {s.Name}");
            }

            Console.Write("\nNhập tên sinh viên cần tìm kiếm: ");
            string searchName = Console.ReadLine();

            var sv = ds.Find(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (sv != null)
            {
                Console.WriteLine($"\n=> Kết quả: Tìm thấy sinh viên '{searchName}' có ID là {sv.Id}");
            }
            else
            {
                Console.WriteLine($"\n=> Kết quả: Không tìm thấy sinh viên nào tên '{searchName}'.");
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}