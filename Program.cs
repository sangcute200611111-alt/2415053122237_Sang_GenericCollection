using System;
using System.Collections.Generic;
using System.Text;

namespace BT_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cài đặt hiển thị tiếng Việt và thông tin sinh viên
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 8");

            // Khởi tạo danh sách Generic List với các giá trị mẫu
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Danh sách gốc: " + string.Join(", ", list));

            // Sử dụng phương thức Reverse để đảo ngược thứ tự các phần tử
            list.Reverse();

            // In danh sách sau khi đã đảo ngược ra màn hình
            Console.WriteLine("Danh sách đảo ngược: " + string.Join(", ", list));

            Console.ReadKey();
        }
    }
}