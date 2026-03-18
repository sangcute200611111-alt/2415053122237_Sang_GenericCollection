using System;
using System.Collections.Generic;
using System.Text;

namespace BT_GenericCollection
{
    // Định nghĩa lớp Student để lưu trữ thông tin
    public class Student { public int Id; public string Name; }
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập font chữ tiếng Việt cho Console
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 11");

            // Khởi tạo danh sách sinh viên bằng Generic List
            List<Student> ds = new List<Student> {
                new Student { Id = 1, Name = "Sang" },
                new Student { Id = 2, Name = "An" },
                new Student { Id = 3, Name = "Bình" }
            };

            Console.WriteLine("Danh sách sinh viên lưu trong List:");
            // Duyệt danh sách và in thông tin từng sinh viên
            foreach (var s in ds)
            {
                Console.WriteLine($"- ID: {s.Id}, Tên: {s.Name}");
            }

            Console.ReadKey();
        }
    }
}