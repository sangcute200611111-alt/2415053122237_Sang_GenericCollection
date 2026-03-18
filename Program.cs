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
            Console.OutputEncoding = Encoding.UTF8;
            string info = "2415053122237 - Võ Văn Sang";
            Console.WriteLine($"{info} | Bài 1");
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nhập số {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Danh sách: " + string.Join(", ", list));
            Console.ReadKey();
        }
    }
}