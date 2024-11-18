using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_buoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            List<sinhvien> sinhviens = new List<sinhvien> { 
            new sinhvien(437,"An Khoi",14),
            new sinhvien(675,"Bao Tran",15),
            new sinhvien(803,"Minh Chau",18),
            new sinhvien(109,"Hoang Duy",17),
            new sinhvien(049,"Ngoc Thao",12),
            new sinhvien(109,"Gia Hung",19)
            };
            //a. In danh sách toàn bộ danh sách học sinh.
            Console.WriteLine("thong tin sinh vien:");
            sinhviens.ForEach(sv => Console.WriteLine(sv));
            //b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18.
            var agelimitsv = sinhviens.Where(s => s.age<=18 && s.age>=15).ToList();
            Console.WriteLine("\ncac hoc sinh tu 15 den 18:");
            agelimitsv.ForEach(s => Console.WriteLine(s));
            //c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A".
            var namestarta =sinhviens.Where(a=>a.name.StartsWith("A")).ToList();
            Console.WriteLine("\nsinh co ten bet đau bang chu A:");
            namestarta.ForEach(s => Console.WriteLine(s));
            //d. Tính tổng tuổi của tất cả học sinh trong danh sách.
            int tage = sinhviens.Sum(s => s.age);
            Console.WriteLine($"\ntong tuoi cua hoc sinh la:{tage}" );
            //e. Tìm và in ra học sinh có tuổi lớn nhất.
            var maxage = sinhviens.OrderByDescending(s => s.age).FirstOrDefault();
            Console.WriteLine($"\nhoc sinh tuoi lon nhat la:{maxage}");
            //f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp.
            var sortage = sinhviens.OrderBy(s => s.age).ToList();
            Console.WriteLine("\ndanh sach hoc sinh theo tuoi tang dang la:");
            sortage.ForEach(s => Console.WriteLine(s));
        }
    }
}
