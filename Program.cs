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
            // Thiết lập font chữ tiếng Việt cho Console
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 14");

            // Khởi tạo danh sách sinh viên ban đầu
            List<Student> ds = new List<Student> {
                new Student { Id = 1, Name = "Sang" },
                new Student { Id = 2, Name = "An" },
                new Student { Id = 3, Name = "Bình" }
            };

            Console.WriteLine("Danh sách trước khi xóa:");
            foreach (var s in ds) Console.WriteLine($"- ID: {s.Id}, Tên: {s.Name}");

            Console.Write("\nNhập ID sinh viên cần xóa: ");
            // Sử dụng TryParse để kiểm tra dữ liệu nhập vào có phải số nguyên không
            if (int.TryParse(Console.ReadLine(), out int idXoa))
            {
                // RemoveAll sẽ xóa tất cả phần tử thỏa mãn điều kiện và trả về số lượng đã xóa
                int check = ds.RemoveAll(s => s.Id == idXoa);
                if (check > 0)
                {
                    Console.WriteLine($"=> Đã xóa thành công sinh viên có ID: {idXoa}");
                    Console.WriteLine("\nDanh sách sau khi xóa:");
                    if (ds.Count > 0)
                        foreach (var s in ds) Console.WriteLine($"- ID: {s.Id}, Tên: {s.Name}");
                    else
                        Console.WriteLine("(Danh sách trống)");
                }
                else
                {
                    Console.WriteLine("=> Không tìm thấy sinh viên nào có ID này.");
                }
            }

            Console.ReadKey();
        }
    }
}