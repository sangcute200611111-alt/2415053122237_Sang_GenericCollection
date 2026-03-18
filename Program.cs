using System;
using System.Collections.Generic;
using System.Text;

namespace BT_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập font chữ tiếng Việt và thông tin sinh viên
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 15");

            // Khởi tạo Dictionary với Key là tiếng Anh và Value là tiếng Việt
            Dictionary<string, string> tuDien = new Dictionary<string, string> {
                {"hello", "xin chào"},
                {"student", "sinh viên"},
                {"computer", "máy tính"}
            };

            Console.WriteLine("Từ điển hiện có: hello, student, computer");
            Console.Write("Nhập từ tiếng Anh cần tra: ");

            // Đọc dữ liệu nhập và chuyển về chữ thường để so khớp chính xác
            string key = Console.ReadLine().ToLower();

            // Sử dụng ContainsKey để kiểm tra sự tồn tại của từ khóa trong từ điển
            if (tuDien.ContainsKey(key))
                Console.WriteLine($"=> Nghĩa của từ '{key}' là: {tuDien[key]}");
            else
                Console.WriteLine("=> Rất tiếc, từ này chưa có trong từ điển.");

            Console.ReadKey();
        }
    }
}