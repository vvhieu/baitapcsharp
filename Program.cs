using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SachGiaoKhoa s1 = new SachGiaoKhoa();
            s1.In();
            SachGiaoKhoa s2 = new SachGiaoKhoa();
            s2.Nhap();
            s2.In();
            Console.ReadLine();
        }
    }
}
