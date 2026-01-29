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
        Console.WriteLine("Bài 3: Kiểm tra chuỗi đối xứng (bỏ khoảng trắng)\n");

        Console.Write("Nhập chuỗi: ");
        string? input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("❌ Kết luận: Không đối xứng (chuỗi null).");
            return;
        }

        // Bỏ khoảng trắng (mạnh hơn: bỏ mọi whitespace như space/tab)
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (!char.IsWhiteSpace(c))
                sb.Append(c);
        }

        string s = sb.ToString();

        // Nếu muốn không phân biệt hoa/thường, bật dòng dưới:
        // s = s.ToLower();

        bool isPalindrome = true;
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }

        Console.WriteLine(isPalindrome ? "✅ Kết luận: Đối xứng" : "❌ Kết luận: Không đối xứng");
    }
}
