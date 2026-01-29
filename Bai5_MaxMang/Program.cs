using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Tên: Dương Phước Quang");
        Console.WriteLine("MSV: 2415053122131");
        Console.WriteLine("Bài 5: Tìm phần tử lớn nhất trong mảng\n");

        Console.Write("Nhập số phần tử n: ");
        string? nText = Console.ReadLine();

        int[]? arr = null;

        if (!int.TryParse(nText, out int n) || n < 0)
        {
            Console.WriteLine("❌ n không hợp lệ.");
        }
        else
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Nhập phần tử [{i}]: ");
                    string? xText = Console.ReadLine();
                    if (int.TryParse(xText, out int x))
                    {
                        arr[i] = x;
                        break;
                    }
                    Console.WriteLine("❌ Nhập không hợp lệ, nhập lại!");
                }
            }
        }

        // Nếu mảng rỗng hoặc null -> không xử lý
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("⚠️ Mảng null hoặc rỗng -> không xử lý.");
            return;
        }

        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
        }

        Console.WriteLine($"✅ Giá trị lớn nhất: {max}");
    }
}
