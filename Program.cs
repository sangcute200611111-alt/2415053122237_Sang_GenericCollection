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
            Console.WriteLine($"{info} | Bài 13");

            // Quản lý tập hợp sinh viên thông qua List đối tượng
            List<Student> danhSachSV = new List<Student> {
                new Student { Id = 1, Name = "Sang" },
                new Student { Id = 2, Name = "An" },
                new Student { Id = 3, Name = "Bình" },
                new Student { Id = 4, Name = "Chi" }
            };

            Console.WriteLine("Danh sách sinh viên hiện có:");
            danhSachSV.ForEach(sv => Console.WriteLine($"- ID: {sv.Id}, Tên: {sv.Name}"));

            Console.WriteLine("\n-------------------------------");
            // Thực hiện đếm và xuất kết quả tổng hợp
            int tongSo = danhSachSV.Count;
            Console.WriteLine("=> Tổng số lượng sinh viên: " + tongSo);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}