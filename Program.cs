using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_GenericCollection
{
    public class Student { public int Id; public string Name; public double Score; }
    class Program
    {
        static void Main(string[] args)
        {
            // Cấu hình hiển thị tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 3");

            // Khởi tạo danh sách số nguyên
            List<int> list = new List<int>();

            Console.Write("Nhập số lượng: ");
            int n = int.Parse(Console.ReadLine());

            // Vòng lặp nhập dữ liệu
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Số {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            // In ra giá trị lớn nhất trong danh sách
            Console.WriteLine("Số lớn nhất: " + list.Max());

            Console.ReadKey();
        }
    }
}