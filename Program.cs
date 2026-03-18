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
            int sl = int.Parse(Console.ReadLine());

            // Thực hiện nhập các phần tử vào danh sách Generic
            for (int i = 0; i < sl; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                int giaTri = int.Parse(Console.ReadLine());
                list.Add(giaTri);
            }

            // Thực hiện thuật toán sắp xếp của hệ thống
            list.Sort();

            // Hiển thị kết quả sau khi sắp xếp ra màn hình
            string ketQua = string.Join(", ", list);
            Console.WriteLine("\nDanh sách sau khi sắp xếp tăng dần:");
            Console.WriteLine(ketQua);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}