// Bài 1: Nhập tên và tuổi, sau đó in ra màn hình thông báo
using System;

namespace BasicExercises
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Nhập tên của bạn: ");
        string name = Console.ReadLine();
        Console.Write("Nhập tuổi của bạn: ");
        string age = Console.ReadLine();
        Console.WriteLine($"Xin chào {name}, bạn {age} tuổi!");

  // Bài 2
        Console.Write("Nhập chiều dài: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập chiều rộng: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Diện tích hình chữ nhật: {length * width}");
  // Bài 3
            Console.Write("Nhập nhiệt độ (°C): ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Nhiệt độ tương ứng: {fahrenheit}°F");

  // Bài 4
            Console.Write("Nhập một số nguyên: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Số chẵn");
            else
                Console.WriteLine("Số lẻ");

  // Bài 5
            Console.Write("Nhập số thứ nhất: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Tổng: {num1 + num2}, Tích: {num1 * num2}");

  // Bài 6
            Console.Write("Nhập một số: ");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number > 0)
                Console.WriteLine("Số dương");
            else if (number < 0)
                Console.WriteLine("Số âm");
            else
                Console.WriteLine("Số không");

   // Bài 7
            Console.Write("Nhập năm: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("Năm nhuận");
            else
                Console.WriteLine("Không phải năm nhuận");

   // Bài 8
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} x {j} = {i * j}\t");
                }
                Console.WriteLine();
            }

    // Bài 9
            Console.Write("Nhập số nguyên dương: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Giai thừa của {n} là {factorial}");

    // Bài 10
            Console.Write("Nhập một số nguyên: ");
            int primeCheck = Convert.ToInt32(Console.ReadLine());
            bool isPrime = primeCheck > 1;
            for (int i = 2; i <= Math.Sqrt(primeCheck); i++)
            {
                if (primeCheck % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "Là số nguyên tố" : "Không phải số nguyên tố");
        }
    }
}
