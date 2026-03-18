using System;
using System.Collections.Generic;
using System.Text;

namespace BT_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập hiển thị tiếng Việt cho Console
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 5");

            // Khởi tạo danh sách sinh viên kiểu Generic List<string>
            List<string> sv = new List<string> { "An", "Bình", "Sang", "Chi" };
            Console.WriteLine("Danh sách: " + string.Join(", ", sv));

            // Nhập tên cần tìm để xóa khỏi danh sách
            Console.Write("Nhập tên cần xóa: ");
            string name = Console.ReadLine();

            // Sử dụng RemoveAll để xóa tất cả các tên trùng khớp (không phân biệt hoa thường)
            sv.RemoveAll(s => s.Equals(name, StringComparison.OrdinalIgnoreCase));

            // Hiển thị lại danh sách sau khi đã xử lý xóa
            Console.WriteLine("Sau khi xóa: " + string.Join(", ", sv));
            Console.ReadKey();
        }
    }
}