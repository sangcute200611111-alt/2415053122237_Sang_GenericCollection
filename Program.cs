using System;
using System.Collections.Generic;
using System.Linq; // Cần Linq để dùng Distinct()
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
            Console.WriteLine($"{info} | Bài 9");

            // Khởi tạo danh sách Generic List kiểu int
            List<int> list = new List<int>();
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());

            // Vòng lặp nhập dữ liệu từ bàn phím vào danh sách
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nDanh sách vừa nhập: " + string.Join(", ", list));

            // Sử dụng Distinct() để lọc ra các phần tử duy nhất (không trùng lặp)
            var uniqueList = list.Distinct().ToList();

            Console.WriteLine("Danh sách sau khi loại bỏ phần tử trùng:");
            Console.WriteLine(string.Join(", ", uniqueList));

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}