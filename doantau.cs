using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class doantau
    {
        string matau;
        int sokhach;
        public void nhaptt()
        {
            Console.WriteLine("nhap ma doan tau");
            this.matau = Console.ReadLine();
            Console.WriteLine("nhap so luong khach");
            this.sokhach = Convert.ToInt32(Console.ReadLine());
        }
        public float tongtien()
        {   float tien;
            if (this.sokhach < 100) tien = this.sokhach * 100000;
            else tien = this.sokhach * 80000;
            return tien;
        }
        public void intien()
        {
            Console.WriteLine("ma tau {0} co tong tien la {1}", this.matau, this.tongtien());
            Console.ReadLine();
        }
    }
}
