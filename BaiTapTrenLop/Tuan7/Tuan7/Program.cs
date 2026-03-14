using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hoang Van Quoc Nhat 2415053122332");
        Random rd = new Random();

        string[] ten = { "An", "Binh", "Chi", "Dung", "Huy", "Lan", "Mai", "Nam", "Phuc", "Tuan" };
        string[] khoa = { "CNTT", "CNS", "QTKD", "DTVT" };

        List<SinhVien> ds = new List<SinhVien>();

        for (int i = 1; i <= 20; i++)
        {
            ds.Add(new SinhVien
            {
                Id = i,
                Ten = ten[rd.Next(ten.Length)],
                Tuoi = rd.Next(18, 25),
                NamHoc = rd.Next(1, 4),
                Khoa = khoa[rd.Next(khoa.Length)],
                DiemTB = Math.Round(rd.NextDouble() * 10, 2)
            });
        }

        var maxTuoi = ds.Max(s => s.Tuoi);
        var minTuoi = ds.Min(s => s.Tuoi);

        Console.WriteLine("\nTuoi lon nhat: " + maxTuoi);
        Console.WriteLine("Tuoi nho nhat: " + minTuoi);

        bool coCNS = ds.Any(s => s.Khoa == "CNS");
        Console.WriteLine("\nCo sinh vien khoa cong nghe so: " + coCNS);

        var top10 = ds
                    .OrderByDescending(s => s.DiemTB)
                    .Take(10);
        Console.WriteLine("\nDanh sach 10 sinh vien co diem cao nhat: ");
        foreach( var t in top10)
        {
            Console.WriteLine($"{t.Ten} - {t.Khoa} - {t.DiemTB}"); 
        }

        Console.WriteLine("\nDanh sach khong co cac sinh vien nam cuoi: ");
        var notSV4 = ds.Where(n => n.NamHoc != 4);
        foreach(var t in notSV4)
        {
            Console.WriteLine($"{t.Ten} - {t.Khoa} - {t.NamHoc}");
        }
    }
}