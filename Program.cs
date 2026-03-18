using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_GenericCollection
{
    public class Student
    {
        public string Name;
        public double Score;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 18");

            List<Student> danhSachSV = new List<Student> {
                new Student { Name = "Nguyễn Văn An", Score = 8.5 },
                new Student { Name = "Trần Thị Chi", Score = 9.2 },
                new Student { Name = "Phạm Minh Đức", Score = 9.8 },
                new Student { Name = "Lê Văn Bình", Score = 7.0 }
            };

            Console.WriteLine("Danh sách sinh viên hiện có:");
            // Duyệt danh sách hiển thị thông tin
            danhSachSV.ForEach(sv => Console.WriteLine($"- {sv.Name}: {sv.Score} điểm"));

            // Tìm kiếm thủ khoa thông qua điểm số cao nhất
            var thuKhoa = danhSachSV.OrderByDescending(student => student.Score).FirstOrDefault();

            if (thuKhoa != null)
            {
                Console.WriteLine("\n-------------------------------");
                Console.WriteLine("=> Sinh viên có điểm cao nhất là:");
                Console.WriteLine($"{thuKhoa.Name} với {thuKhoa.Score} điểm");
            }

            Console.ReadKey();
        }
    }
}