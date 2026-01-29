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
        Console.WriteLine("Bài 1: Chuẩn hoá chuỗi họ tên\n");

        Console.Write("Nhập họ tên (có thể dư khoảng trắng): ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("❌ Lỗi: Chuỗi null hoặc rỗng.");
            return;
        }

        input = input.Trim();

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < parts.Length; i++)
        {
            string w = parts[i].Trim();
            if (w.Length == 0) continue;

            string first = w.Substring(0, 1).ToUpper();
            string rest = (w.Length > 1) ? w.Substring(1).ToLower() : "";

            if (result.Length > 0) result.Append(' ');
            result.Append(first).Append(rest);
        }

        Console.WriteLine("✅ Họ tên chuẩn hoá: " + result.ToString());
    }
}
