using System;
using System.Collections.Generic;
using System.Text;

namespace BT_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập font chữ tiếng Việt cho nhập và xuất dữ liệu
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 16");

            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();

            // Sử dụng Dictionary để lưu trữ cặp: Ký tự (Key) - Số lần (Value)
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                // Bỏ qua ký tự khoảng trắng
                if (c == ' ') continue;

                // Nếu ký tự đã tồn tại thì tăng số lượng, ngược lại thì thêm mới
                if (counts.ContainsKey(c)) counts[c]++;
                else counts[c] = 1;
            }

            Console.WriteLine("\nKết quả:");
            // Duyệt Dictionary để in tần suất xuất hiện của từng ký tự
            foreach (var item in counts)
            {
                Console.WriteLine($"- '{item.Key}': {item.Value}");
            }

            Console.ReadKey();
        }
    }
}