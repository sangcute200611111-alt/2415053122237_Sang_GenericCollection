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
            Console.WriteLine($"{info} | Bài 5");
            List<string> sv = new List<string> { "An", "Bình", "Sang", "Chi" };
            Console.WriteLine("Danh sách: " + string.Join(", ", sv));
            Console.Write("Nhập tên cần xóa: ");
            string name = Console.ReadLine();
            sv.RemoveAll(s => s.Equals(name, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Sau khi xóa: " + string.Join(", ", sv));
            Console.ReadKey();
        }
    }
}