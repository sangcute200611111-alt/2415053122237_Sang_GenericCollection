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
            string input = Console.ReadLine();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ') continue;
                if (counts.ContainsKey(c)) counts[c]++;
                else counts[c] = 1;
            }

            Console.WriteLine("\nKết quả:");
            foreach (var item in counts)
            {
                Console.WriteLine($"- '{item.Key}': {item.Value}");
            }

            Console.ReadKey();
        }
    }
}