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

            // Chuyển danh sách thành chuỗi hiển thị ban đầu
            string dsBanDau = string.Join(", ", sv);
            Console.WriteLine("Danh sách: " + dsBanDau);

            Console.Write("Nhập tên cần xóa: ");
            string nameToDelete = Console.ReadLine();

            // Thực hiện lệnh xóa phần tử theo điều kiện
            sv.RemoveAll(s => s.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));

            // Xuất kết quả sau khi cập nhật danh sách
            string dsSauKhiXoa = string.Join(", ", sv);
            Console.WriteLine("Sau khi xóa: " + dsSauKhiXoa);

            Console.ReadKey();
        }
    }
}