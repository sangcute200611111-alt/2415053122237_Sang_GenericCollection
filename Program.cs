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
            Console.WriteLine($"{info} | Bài 14");

            List<Student> ds = new List<Student> {
                new Student { Id = 101, Name = "Sang" },
                new Student { Id = 102, Name = "An" },
                new Student { Id = 103, Name = "Bình" }
            };

            Console.WriteLine("Danh sách trước khi xóa: ");
            foreach (var s in ds) Console.WriteLine($"- ID: {s.Id}, Tên: {s.Name}");

            Console.Write("\nNhập ID sinh viên cần xóa: ");
            if (int.TryParse(Console.ReadLine(), out int idXoa))
            {
                int check = ds.RemoveAll(s => s.Id == idXoa);
                if (check > 0)
                {
                    Console.WriteLine("=> Đã xóa thành công.");
                    Console.WriteLine("Danh sách sau khi xóa: " + string.Join(", ", ds.ConvertAll(s => s.Name)));
                }
                else Console.WriteLine("=> Không tìm thấy ID này.");
            }

            Console.ReadKey();
        }
    }
}