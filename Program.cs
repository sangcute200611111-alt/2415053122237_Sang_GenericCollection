using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 4");
            List<int> list = new List<int>();
            Console.Write("Nhập số lượng số cần kiểm tra: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Số lượng số chẵn: " + list.Count(x => x % 2 == 0));
            Console.ReadKey();
        }
    }
}