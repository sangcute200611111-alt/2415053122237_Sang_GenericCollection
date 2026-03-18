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
            // Cài đặt hiển thị tiếng Việt và thông tin sinh viên
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 2");

            // Khởi tạo List số nguyên và nhập số lượng phần tử
            List<int> list = new List<int>();
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());

            // Vòng lặp nhập từng giá trị và thêm vào danh sách
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            // Sử dụng phương thức Sum() của LINQ để tính tổng nhanh
            Console.WriteLine("Tổng các phần tử: " + list.Sum());
            Console.ReadKey();
        }
    }
}