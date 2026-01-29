using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Tên: Dương Phước Quang");
        Console.WriteLine("MSV: 2415053122131");
        Console.WriteLine("Bài 6: Đếm số phần tử chẵn\n");

        Console.Write("Nhập số phần tử n: ");
        string? nText = Console.ReadLine();

        int[]? arr = null;

        if (!int.TryParse(nText, out int n) || n < 0)
        {
            Console.WriteLine("⚠️ n không hợp lệ -> mảng null.");
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

        int countEven = CountEven(arr);
        Console.WriteLine($"✅ Số phần tử chẵn: {countEven}");
    }

    static int CountEven(int[]? arr)
    {
        if (arr == null) return 0;

        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) count++;
        }
        return count;
    }
}
