using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332");
            List<Student> students = new List<Student>()
                {
                    new Student{Id=1, Name="An", Score=8},
                    new Student{Id=2, Name="Binh", Score=6},
                    new Student{Id=3, Name="Chi", Score=9},
                    new Student{Id=4, Name="Dung", Score=7}
                };
            var svGioi = students.Where(s => s.Score >= 8);
            Console.WriteLine("\nSinh vien gioi: ");
            foreach (var student in svGioi) 
            { 
                Console.WriteLine(student.Name); 
            }

            var tenSV = students.Select(s => s.Name);
            Console.WriteLine("\nTen cua tung sinh vien: ");
            foreach (var ten in tenSV)
            {
                Console.WriteLine(ten);
            }

            var diemGiam = students.OrderByDescending(s => s.Score);
            Console.WriteLine("\nSap xep diem giam dan:");
            foreach (var s in diemGiam)
            {
                Console.WriteLine($"{s.Name} - {s.Score}");
            }

            var diemCaoNhat = students.OrderByDescending(s => s.Score).FirstOrDefault();
            Console.WriteLine("\nSinh vien co diem cao nhat:");
            Console.WriteLine($"{diemCaoNhat.Name} - {diemCaoNhat.Score}");

            var diem7 = students.Count(s => s.Score > 7);
            Console.WriteLine("\nSo sinh vien dat: ");
            Console.WriteLine(diem7);

            var diem7First = students.FirstOrDefault(s => s.Score > 7);
            Console.WriteLine("\nSinh vien dau tien dat diem 7: ");
            Console.WriteLine($"{diem7First.Name}");

            bool svRot = students.Any(s => s.Score < 5);
            Console.WriteLine("\nCo sinh vien rot khong: ");
            if (svRot)
                Console.WriteLine("Co");
            else
                Console.WriteLine("Khong");
        }
    }
}
