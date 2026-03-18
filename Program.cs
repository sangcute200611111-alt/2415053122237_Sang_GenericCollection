using System;
using System.Collections.Generic;
using System.Text;

namespace BT_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập hiển thị tiếng Việt và thông tin sinh viên
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 6");

            // Khởi tạo Generic List chứa các chuỗi lập trình
            List<string> ds = new List<string> { "C#", "Java", "Python" };

            // Giá trị cần kiểm tra sự tồn tại trong danh sách
            string check = "C#";

            // In danh sách hiện tại ra màn hình
            Console.WriteLine("Danh sách: " + string.Join(", ", ds));

            // Sử dụng phương thức Contains để kiểm tra phần tử
            string ketQua = ds.Contains(check) ? "Có tồn tại" : "Không tồn tại";
            Console.WriteLine($"Kiểm tra '{check}': " + ketQua);

            Console.ReadKey();
        }
    }
}