using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so sinh vien");
            n = Int32.Parse(Console.ReadLine());
            //tao mang doi tuong sinh vien
            SinhVien[] sv = new SinhVien[n];
            for (int i = 0; i<n; i++)
            {
               sv[i] = new SinhVien();
                sv[i].Nhap();
                sv[i].diemtb();
                sv[i].In();
            }
            //tim ra sinh vien nao co diem thap nhat
            float min = sv[0].diemtb();
            for (int i = 1; i < n; i++)
            {
                if (sv[i].diemtb() < min) min = sv[i].diemtb();
            }
                Console.WriteLine("sv co diem thap nhat la: {0}", min);
            //tim ra ma sinh vien  co chua chu 18i
            for (int i=0; i<n; i++)
            {
                if (sv[i].maSV.Contains("18i"))
                    Console.WriteLine("sinh vien co ma {0} co diem tb {1} co chua chu 18i", sv[i].maSV, sv[i].diemtb());
            }
            //sap xep mang sinh vien theo diem tb tang dan
            SinhVien t;
                for(int i=0; i<n; i++)
                {
                    for (int j = i; j < n; j++)
                    {
                        if (sv[i].diemtb() > sv[j].diemtb())
                        {
                        t = sv[i];
                        sv[i] = sv[j];
                        sv[j] = t;
                        }
                    }
                }

            Console.WriteLine("sap xep sinh vien theo thu tu tang dan:");
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("sinh vien co ma {0} co diem tb {1}", sv[i].maSV, sv[i].diemtb());
            }
            Console.ReadLine();
        }
    }
}
