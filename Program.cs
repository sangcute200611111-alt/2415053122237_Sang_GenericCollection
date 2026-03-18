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
            Console.WriteLine($"{info} | Bài 8");
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Danh sách gốc: " + string.Join(", ", list));
            list.Reverse();
            Console.WriteLine("Danh sách đảo ngược: " + string.Join(", ", list));
            Console.ReadKey();
        }
    }
}