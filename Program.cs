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
            Console.WriteLine($"{info} | Bài 17");

            List<int> list = new List<int>();
            Console.Write("Nhập số lượng phần tử của danh sách: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    int giaTri = int.Parse(Console.ReadLine());
                    list.Add(giaTri);
                }

                Console.WriteLine("\nDanh sách vừa nhập: " + string.Join(", ", list));

                // Phân tích tần suất xuất hiện của các phần tử
                if (list.Count > 0)
                {
                    var thongKe = list.GroupBy(num => num)
                                     .OrderByDescending(nhom => nhom.Count())
                                     .ToList();

                    var ketQuaMax = thongKe.First();

                    // Hiển thị kết quả tìm kiếm ra màn hình Console
                    Console.WriteLine($"\n=> Số xuất hiện nhiều nhất là: {ketQuaMax.Key}");
                    Console.WriteLine($"\n=> Số lần xuất hiện: {ketQuaMax.Count()} lần");
                }
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}