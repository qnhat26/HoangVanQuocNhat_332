using Bai17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332");
            List<Student> students = new List<Student>() { new Student { Id = 1, Name = "An", Score = 8 }, new Student { Id = 2, Name = "Binh", Score = 6 }, new Student { Id = 3, Name = "Chi", Score = 9 }, new Student { Id = 4, Name = "Dung", Score = 7 } };
            var top3 = students
                        .OrderByDescending(x => x.Score)
                        .Take(3);
            foreach(var t in top3) 
            {
                Console.WriteLine(t.Name + " - " + t.Score);            
            }
        }
    }
}
