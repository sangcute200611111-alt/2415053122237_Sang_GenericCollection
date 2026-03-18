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
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 7");

            List<int> list = new List<int>();
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            list.Sort();
            Console.WriteLine("\nDanh sách sau khi sắp xếp tăng dần:");
            Console.WriteLine(string.Join(", ", list));

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}