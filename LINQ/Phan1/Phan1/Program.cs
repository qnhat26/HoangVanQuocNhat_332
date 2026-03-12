using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 8, 5, 6, 7 };

            Console.WriteLine("\nCac so chan trong day: ");
            var soChan = numbers.Where(n => n % 2 == 0);
            foreach (var n in soChan)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nCac so lon hon 5 trong day: ");
            var five = numbers.Where(n => n > 5);
            foreach (var n in five)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nSap xep tang dan: ");
            var tangDan = numbers.OrderBy(n => n);
            foreach (int n in tangDan)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n\nSap xep giam dan: ");
            var giamDan = numbers.OrderByDescending(n => n);
            foreach (var n in giamDan)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n\nBinh phuong cac so trong day: ");
            var binhPhuong = numbers.Select(n => n * n);
            foreach (var n in binhPhuong)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nSo phan tu chan trong day: ");
            var soPtuChan = numbers.Count(n => n % 2 == 0);
            Console.WriteLine(soPtuChan);

            Console.WriteLine("\nTrong day co so lon hon 10 khong? ");
            bool lonHon10 = numbers.Any(n => n > 10);
            if (lonHon10)
                Console.WriteLine("Co");
            else
                Console.WriteLine("Khong");
        }
    }
}
