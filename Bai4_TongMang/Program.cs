using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Tên: Dương Phước Quang");
        Console.WriteLine("MSV: 2415053122131");
        Console.WriteLine("Bài 4: Tính tổng mảng số nguyên\n");

        Console.Write("Nhập số phần tử n: ");
        string? nText = Console.ReadLine();

        int[]? arr = null;


        if (string.IsNullOrWhiteSpace(nText) || !int.TryParse(nText, out int n) || n < 0)
        {
            Console.WriteLine("❌ Lỗi: n không hợp lệ.");
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

        if (arr == null)
        {
            Console.WriteLine("❌ Lỗi: Mảng chưa được khởi tạo.");
            return;
        }

        long sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];

        Console.WriteLine($"✅ Tổng các phần tử: {sum}");
    }
}
