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
            Console.WriteLine($"{info} | Bài 15");

            // Khai báo tập hợp dữ liệu từ điển Anh - Việt
            Dictionary<string, string> dictionary = new Dictionary<string, string> {
                {"hello", "xin chào"},
                {"student", "sinh viên"},
                {"computer", "máy tính"}
            };

            Console.WriteLine("Từ điển hiện có: hello, student, computer");
            Console.Write("Nhập từ tiếng Anh cần tra: ");
            string inputKey = Console.ReadLine().ToLower();

            // Kiểm tra và hiển thị kết quả dịch thuật
            if (dictionary.ContainsKey(inputKey))
            {
                string nghiaCuaTu = dictionary[inputKey];
                Console.WriteLine($"=> Nghĩa của từ '{inputKey}' là: {nghiaCuaTu}");
            }
            else
            {
                Console.WriteLine("=> Rất tiếc, từ này chưa có trong từ điển.");
            }

            Console.ReadKey();
        }
    }
}