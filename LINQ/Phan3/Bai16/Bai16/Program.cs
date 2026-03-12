using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332");
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            var tong = numbers.Sum();
            Console.WriteLine("Tong: "+tong);
        }
    }
}
