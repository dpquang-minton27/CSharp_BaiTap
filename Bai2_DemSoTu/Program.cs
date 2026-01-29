using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Tên: Dương Phước Quang");
        Console.WriteLine("MSV: 2415053122131");
        Console.WriteLine("Bài 2: Đếm số từ trong chuỗi\n");

        Console.Write("Nhập chuỗi bất kỳ: ");
        string? input = Console.ReadLine();

        // Nếu chuỗi null -> in 0
        if (input == null)
        {
            Console.WriteLine("✅ Số từ: 0");
            return;
        }

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("✅ Số từ: 0");
            return;
        }

        input = input.Trim();

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Không dùng LINQ => dùng Length
        Console.WriteLine("✅ Số từ: " + words.Length);
    }
}
