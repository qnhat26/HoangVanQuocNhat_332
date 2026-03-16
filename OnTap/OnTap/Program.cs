using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Products> listSp = new List<Products>();
            for (int i = 1; i <= 6; i++)
            {
                Products p = new Products();
                p.Product = "PR" + i;
                p.ID = i;
                p.Name = "SP" + i;
                p.Price =  random.Next(400,600);
                p.Category = "Loai " +i;
                listSp.Add(p);
            }

            var gia500 = listSp.Where(s => s.Price > 500);
            Console.WriteLine("Danh sach san pham co gia >500: ");
            foreach (Products p in gia500) 
                Console.WriteLine($"{p.Name} - {p.Price}");

            var tang = listSp.OrderBy(s => s.Price);
            Console.WriteLine("\nDanh sach san pham co gia tang dan:");
            foreach(Products p in tang)
                Console.WriteLine($"{p.Name} - {p.Price}");

            var re1 = listSp.OrderByDescending(s => s.Price).Take(3);
            Console.WriteLine("\nDanh sach 3 san pham re nhat: ");
            foreach(var t in re1)
                Console.WriteLine($"{t.Name} - {t.Price}");

            Console.Write("Nhap mat hang muon tim: ");
            string input = Console.ReadLine();
            var cau34 = listSp.Where(p => p.Name.Contains(input)).ToList();
            if (cau34.Count == 0)
                Console.WriteLine("Khong tim thay san pham nao!");
            foreach (var p in cau34)
                Console.WriteLine($"Id: {p.ID}, Name: {p.Name}, Price: {p.Price}, Category: {p.Category}");
            
            var tong = listSp.Sum(x => x.Price);
            Console.WriteLine("\nTong gia tri: " + tong);

            var trungbinh = listSp.Average(x => x.Price);
            Console.WriteLine("Trung binh gia tri: " + trungbinh);
        }
    }
}
