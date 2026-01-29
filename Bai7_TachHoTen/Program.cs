using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Tên: Dương Phước Quang");
        Console.WriteLine("MSV: 2415053122131");
        Console.WriteLine("Bài 7: Tách họ tên thành mảng\n");

        Console.Write("Nhập họ tên: ");
        string? input = Console.ReadLine();

        // Chuỗi null -> không tách
        if (input == null)
        {
            Console.WriteLine("⚠️ Chuỗi null -> không tách.");
            return;
        }

        string[]? parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Mảng kết quả null -> không in (thực tế Split không trả null, nhưng vẫn check theo yêu cầu)
        if (parts == null)
        {
            Console.WriteLine("⚠️ Mảng kết quả null -> không in.");
            return;
        }

        if (parts.Length == 0)
        {
            Console.WriteLine("⚠️ Không có từ nào để in.");
            return;
        }

        Console.WriteLine("\nCác từ trong họ tên:");
        for (int i = 0; i < parts.Length; i++)
        {
            Console.WriteLine(parts[i]);
        }
    }
}
