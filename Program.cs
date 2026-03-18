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

            List<Student> ds = new List<Student> {
                new Student { Name = "Nguyễn Văn An", Score = 8.5 },
                new Student { Name = "Trần Thị Chi", Score = 9.2 },
                new Student { Name = "Phạm Minh Đức", Score = 9.8 },
                new Student { Name = "Lê Văn Bình", Score = 7.0 }
            };

            Console.WriteLine("Danh sách sinh viên hiện có:");
            foreach (var s in ds)
            {
                Console.WriteLine($"- {s.Name}: {s.Score} điểm");
            }

            var topStudent = ds.OrderByDescending(s => s.Score).First();

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("=> Sinh viên có điểm cao nhất là:");
            Console.WriteLine($"{topStudent.Name} với {topStudent.Score} điểm");

            Console.ReadKey();
        }
    }
}