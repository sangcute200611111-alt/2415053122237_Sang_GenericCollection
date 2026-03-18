using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cài đặt hiển thị tiếng Việt và thông tin sinh viên
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 4");

            // Khởi tạo danh sách Generic List để lưu các số nguyên
            List<int> list = new List<int>();

            Console.Write("Nhập số lượng số cần kiểm tra: ");
            int n = int.Parse(Console.ReadLine());

            // Vòng lặp for để nhập dữ liệu từ bàn phím vào List
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            // Đếm số lượng các số chẵn trong danh sách và in kết quả
            Console.WriteLine("Số lượng số chẵn: " + list.Count(x => x % 2 == 0));

            Console.ReadKey();
        }
    }
}