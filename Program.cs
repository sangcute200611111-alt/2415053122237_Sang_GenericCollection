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
            Console.InputEncoding = Encoding.UTF8;

            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 18");

            List<int> list = new List<int>();
            Console.Write("Nhập số lượng phần tử: ");

            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhập số thứ {i + 1}: ");
                    list.Add(int.Parse(Console.ReadLine()));
                }

                // Nhóm và đếm số lần xuất hiện
                var groups = list.GroupBy(x => x)
                                 .OrderByDescending(g => g.Count())
                                 .ThenBy(g => g.Key) // Nếu số lần bằng nhau, lấy số nhỏ hơn trước cho khoa học
                                 .ToList();

                var mostFrequent = groups.First();
                int maxCount = mostFrequent.Count();

                // Kiểm tra nếu tất cả đều xuất hiện 1 lần
                if (maxCount == 1 && list.Count > 1)
                {
                    Console.WriteLine("\n=> Các số đều xuất hiện 1 lần như nhau.");
                    Console.WriteLine($"=> Số đầu tiên trong danh sách là: {mostFrequent.Key}");
                }
                else
                {
                    Console.WriteLine($"\n=> Số xuất hiện nhiều nhất: {mostFrequent.Key}");
                    Console.WriteLine($"=> Số lần xuất hiện: {maxCount} lần");
                }
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}