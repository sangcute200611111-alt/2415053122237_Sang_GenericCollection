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
            // Thiết lập hiển thị tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 10");

            // Khởi tạo danh sách số nguyên có sẵn phần tử
            List<int> list = new List<int> { 15, 42, 5, 89, 23 };

            // In danh sách ra màn hình Console
            Console.WriteLine("Danh sách: " + string.Join(", ", list));

            // Sử dụng phương thức Min() để tìm giá trị nhỏ nhất
            Console.WriteLine("Giá trị nhỏ nhất: " + list.Min());

            Console.ReadKey();
        }
    }
}