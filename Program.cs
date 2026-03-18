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
            // Thiết lập font chữ và thông tin cá nhân
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 17");

            List<int> list = new List<int>();
            Console.Write("Nhập số lượng phần tử của danh sách: ");

            // Sử dụng TryParse để nhập liệu an toàn
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    list.Add(int.Parse(Console.ReadLine()));
                }

                Console.WriteLine("\nDanh sách vừa nhập: " + string.Join(", ", list));

                if (list.Count > 0)
                {
                    // Giải thuật: Nhóm các số giống nhau, sau đó sắp xếp theo số lượng giảm dần
                    var groups = list.GroupBy(x => x)
                                     .OrderByDescending(g => g.Count())
                                     .ToList();

                    // Lấy nhóm đầu tiên (nhóm có số lần xuất hiện nhiều nhất)
                    var mostFrequent = groups.First();

                    Console.WriteLine($"\n=> Số xuất hiện nhiều nhất là: {mostFrequent.Key}");
                    Console.WriteLine($"=> Số lần xuất hiện: {mostFrequent.Count()} lần");
                }
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}