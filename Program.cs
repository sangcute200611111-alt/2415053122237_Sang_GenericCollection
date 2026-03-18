using System;
using System.Collections.Generic;
using System.Text;

namespace BT_GenericCollection
{
    public class Student { public int Id; public string Name; }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 14");

            // Quản lý tập hợp sinh viên thông qua List Generic
            List<Student> danhSachSV = new List<Student> {
                new Student { Id = 1, Name = "Sang" },
                new Student { Id = 2, Name = "An" },
                new Student { Id = 3, Name = "Bình" }
            };

            Console.WriteLine("Danh sách trước khi xóa:");
            danhSachSV.ForEach(sv => Console.WriteLine($"- ID: {sv.Id}, Tên: {sv.Name}"));

            Console.Write("\nNhập ID sinh viên cần xóa: ");
            string inputID = Console.ReadLine();

            if (int.TryParse(inputID, out int idCanXoa))
            {
                // Thực hiện lệnh xóa dựa trên ID đã nhập
                int soLuongXoa = danhSachSV.RemoveAll(item => item.Id == idCanXoa);

                if (soLuongXoa > 0)
                {
                    Console.WriteLine($"=> Đã xóa thành công sinh viên có ID: {idCanXoa}");
                    Console.WriteLine("\nDanh sách sau khi xóa:");
                    if (danhSachSV.Count > 0)
                        danhSachSV.ForEach(sv => Console.WriteLine($"- ID: {sv.Id}, Tên: {sv.Name}"));
                    else
                        Console.WriteLine("(Danh sách trống)");
                }
                else
                {
                    Console.WriteLine("=> Không tìm thấy sinh viên nào có ID này.");
                }
            }

            Console.ReadKey();
        }
    }
}