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

            // Quản lý dữ liệu sinh viên thông qua tập hợp List
            List<Student> danhSach = new List<Student> {
                new Student { Id = 1, Name = "Sang" },
                new Student { Id = 2, Name = "An" },
                new Student { Id = 3, Name = "Bình" }
            };

            Console.WriteLine("Danh sách sinh viên hiện có:");
            danhSach.ForEach(item => Console.WriteLine($"- ID: {item.Id}, Tên: {item.Name}"));

            Console.Write("\nNhập tên sinh viên cần tìm kiếm: ");
            string tenCanTim = Console.ReadLine();

            // Thực hiện truy vấn tìm kiếm phần tử đầu tiên thỏa mãn điều kiện
            var ketQuaTimKiem = danhSach.Find(sv => sv.Name.Equals(tenCanTim, StringComparison.OrdinalIgnoreCase));

            if (ketQuaTimKiem != null)
            {
                Console.WriteLine($"\n=> Kết quả: Tìm thấy sinh viên '{tenCanTim}' có ID là {ketQuaTimKiem.Id}");
            }
            else
            {
                Console.WriteLine($"\n=> Kết quả: Không tìm thấy sinh viên nào tên '{tenCanTim}'.");
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}