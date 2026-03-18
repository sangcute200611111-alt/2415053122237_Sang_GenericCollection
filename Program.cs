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

            // Hiển thị trạng thái ban đầu của danh sách
            string dsGoc = string.Join(", ", list);
            Console.WriteLine("Danh sách gốc: " + dsGoc);

            // Thực hiện đảo ngược danh sách
            list.Reverse();

            // Hiển thị trạng thái sau khi xử lý
            string dsDaoNguoc = string.Join(", ", list);
            Console.WriteLine("Danh sách đảo ngược: " + dsDaoNguoc);

            Console.ReadKey();
        }
    }
}