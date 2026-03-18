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
            Console.WriteLine($"{info} | Bài 6");
            List<string> ds = new List<string> { "C#", "Java", "Python" };
            string check = "C#";
            Console.WriteLine("Danh sách: " + string.Join(", ", ds));
            Console.WriteLine($"Kiểm tra '{check}': " + (ds.Contains(check) ? "Có tồn tại" : "Không tồn tại"));
            Console.ReadKey();
        }
    }
}