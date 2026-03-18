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
            // Cấu hình hiển thị tiếng Việt cho Console
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            
            // Hiển thị tiêu đề bài tập
            Console.WriteLine($"{info} | Bài 1: Quản lý danh sách số nguyên");

            // Khởi tạo Generic List kiểu int
            List<int> list = new List<int>();

            // Vòng lặp nhập 5 phần tử từ bàn phím
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nhập số nguyên thứ {i + 1}: ");
                // Chuyển đổi dữ liệu nhập từ string sang int và thêm vào List
                list.Add(int.Parse(Console.ReadLine()));
            }

            // Xuất toàn bộ danh sách ra màn hình
            Console.WriteLine("=> Danh sách đã nhập: " + string.Join(", ", list));
            Console.ReadKey();
        }
    }
}