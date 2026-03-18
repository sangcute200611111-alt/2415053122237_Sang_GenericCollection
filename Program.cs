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
            string ngonNguCanCheck = "C#";

            // Hiển thị danh sách các ngôn ngữ
            string hienThiDS = string.Join(", ", ds);
            Console.WriteLine("Danh sách: " + hienThiDS);

            // Kiểm tra và xuất kết quả tồn tại
            bool tonTai = ds.Contains(ngonNguCanCheck);
            string thongBao = tonTai ? "Có tồn tại" : "Không tồn tại";

            Console.WriteLine($"Kiểm tra '{ngonNguCanCheck}': " + thongBao);

            Console.ReadKey();
        }
    }
}