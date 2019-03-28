using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapheritance
{
    class SachGiaoKhoa:Sach
    {
        int DonGia;
        int SoLuong;
        String tinhtrangSach;
        public SachGiaoKhoa() : base()
        {
            this.tinhtrangSach = "moi";
            this.DonGia = 100000;
            this.SoLuong = 1;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Tinh trang sach:");
            this.tinhtrangSach = Console.ReadLine();
            Console.WriteLine("Don gia sach:");
            this.DonGia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("so luong sach:");
            this.SoLuong = Int32.Parse(Console.ReadLine());
        }
        public int tienSach()
        {
            int tien = 0;
            if (this.tinhtrangSach == "moi")
            {
                tien = this.SoLuong * this.DonGia;
            }
            else if(this.tinhtrangSach == "cu")
            {
                tien = this.SoLuong * this.DonGia * 50;
            }
            return tien;
        }
        public new void In()
        {
            base.In();
            Console.WriteLine("so tien phai tra la:"+this.tienSach());
            Console.ReadLine();
        }
    }
}
