using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Tên: Dương Phước Quang");
        Console.WriteLine("MSV: 2415053122131");
        Console.WriteLine("Bài 9: Đếm số chuỗi khác null và khác rỗng\n");

        Console.Write("Nhập số phần tử n: ");
        string? nText = Console.ReadLine();

        if (!int.TryParse(nText, out int n) || n < 0)
        {
            Console.WriteLine("❌ n không hợp lệ.");
            return;
        }

        string[] arr = new string[n];

        Console.WriteLine("Nhập từng chuỗi (gõ đúng chữ null để lưu giá trị null):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            string? s = Console.ReadLine();

            if (s == null)
            {
                arr[i] = null!;
            }
            else if (s.Trim().Equals("null", StringComparison.OrdinalIgnoreCase))
            {
                arr[i] = null!;
            }
            else
            {
                arr[i] = s; // có thể rỗng, sẽ lọc khi đếm
            }
        }

        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            // khác null và khác rỗng (và không chỉ toàn khoảng trắng)
            if (arr[i] != null && !string.IsNullOrWhiteSpace(arr[i]))
                count++;
        }

        Console.WriteLine($"✅ Số chuỗi khác null và khác rỗng: {count}");
    }
}
