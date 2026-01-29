using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Tên: Dương Phước Quang");
        Console.WriteLine("MSV: 2415053122131");
        Console.WriteLine("Bài 8: Tìm từ dài nhất trong chuỗi\n");

        Console.Write("Nhập 1 câu: ");
        string? input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("⚠️ Chuỗi null -> không xử lý.");
            return;
        }

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("⚠️ Câu rỗng/ toàn khoảng trắng.");
            return;
        }

        string[] words = input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
        {
            Console.WriteLine("⚠️ Không có từ nào.");
            return;
        }

        string longest = words[0];
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
                longest = words[i];
        }

        Console.WriteLine($"✅ Từ dài nhất: {longest}");
        Console.WriteLine($"✅ Độ dài: {longest.Length}");
    }
}
