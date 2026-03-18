using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 9");

            List<int> list = new List<int>();
            Console.Write("Nhập số lượng phần tử: ");
            int sl = int.Parse(Console.ReadLine());

            for (int i = 0; i < sl; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                int giaTri = int.Parse(Console.ReadLine());
                list.Add(giaTri);
            }

            // Hiển thị danh sách gốc đã nhập
            string dsGoc = string.Join(", ", list);
            Console.WriteLine("\nDanh sách vừa nhập: " + dsGoc);

            // Xử lý loại bỏ các phần tử trùng nhau trong danh sách
            var uniqueList = list.Distinct().ToList();

            // Hiển thị danh sách kết quả sau khi đã lọc
            string dsLoc = string.Join(", ", uniqueList);
            Console.WriteLine("Danh sách sau khi loại bỏ phần tử trùng:");
            Console.WriteLine(dsLoc);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}