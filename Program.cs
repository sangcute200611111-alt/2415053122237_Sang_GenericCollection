using System;
using System.Collections.Generic;
using System.Text;

namespace BT_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 16");

            Console.Write("Nhập chuỗi: ");
            string inputStr = Console.ReadLine();

            // Khởi tạo tập hợp lưu trữ số lượng ký tự
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char kyTu in inputStr)
            {
                if (kyTu == ' ') continue;

                // Cập nhật số lần xuất hiện của ký tự
                if (charCounts.ContainsKey(kyTu)) charCounts[kyTu]++;
                else charCounts[kyTu] = 1;
            }

            Console.WriteLine("\nKết quả:");
            // Xuất thông tin thống kê ra màn hình
            foreach (KeyValuePair<char, int> entry in charCounts)
            {
                Console.WriteLine($"- '{entry.Key}': {entry.Value}");
            }

            Console.ReadKey();
        }
    }
}