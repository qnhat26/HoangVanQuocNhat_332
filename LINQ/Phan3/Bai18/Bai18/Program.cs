using Bai17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332");
            List<Student> students = new List<Student>() { new Student { Id = 1, Name = "An", Score = 8 }, new Student { Id = 2, Name = "Binh", Score = 6 }, new Student { Id = 3, Name = "Chi", Score = 9 }, new Student { Id = 4, Name = "Dung", Score = 7 } };
            var nhomSV = students.GroupBy(s =>
            {
                if (s.Score >= 8) return "Gioi";
                else if (s.Score >= 6) return "Kha";
                else return "Trung binh";
            }
            );

            foreach (var student in nhomSV) 
            {
                Console.WriteLine(student.Key);
                foreach (var s in student)
                {
                    Console.WriteLine($"{s.Name} - {s.Score}");
                }
            }
        }
    }
}
