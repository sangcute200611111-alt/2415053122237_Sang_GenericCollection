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
            Console.WriteLine($"{info} | Bài 10");
            List<int> list = new List<int> { 15, 42, 5, 89, 23 };
            Console.WriteLine("Danh sách: " + string.Join(", ", list));
            Console.WriteLine("Giá trị nhỏ nhất: " + list.Min());
            Console.ReadKey();
        }
    }
}