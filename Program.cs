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
            // Thiết lập font chữ tiếng Việt và thông tin sinh viên
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 13");

            // Khởi tạo danh sách sinh viên bằng Generic List<Student>
            List<Student> ds = new List<Student> {
                new Student { Id = 1, Name = "Sang" },
                new Student { Id = 2, Name = "An" },
                new Student { Id = 3, Name = "Bình" },
                new Student { Id = 4, Name = "Chi" }
            };

            Console.WriteLine("Danh sách sinh viên hiện có:");
            // Sử dụng vòng lặp foreach để duyệt qua từng đối tượng trong danh sách
            foreach (var s in ds)
            {
                Console.WriteLine($"- ID: {s.Id}, Tên: {s.Name}");
            }

            Console.WriteLine("\n-------------------------------");
            // Sử dụng thuộc tính .Count để lấy tổng số phần tử hiện có trong List
            Console.WriteLine("=> Tổng số lượng sinh viên: " + ds.Count);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}