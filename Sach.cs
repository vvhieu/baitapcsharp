using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapheritance
{
    class Sach
    {
        String maSach;
        String NgayNhap;
        public Sach()
        {
            this.maSach = "abc";
            this.NgayNhap = "28 / 3 / 2019";
        }
        public void Nhap()
        {
            Console.WriteLine("Ma sach la:");
            this.maSach = Console.ReadLine();
            Console.WriteLine("Ngay nhap la:");
            this.NgayNhap = Console.ReadLine();
        }
        public void In()
        {
            Console.WriteLine("Sach co ma {0} co ngay nhap {1}", this.maSach, this.NgayNhap);
        }
    }
}
