using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class tinhtong
    {
        public int tong1()
        {
            int n1, s1 = 0;
            Console.WriteLine("nhap n1: ");
            n1 = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n1; i++)
                if (i % 2 == 1)
                {
                    s1 = s1 + i;
                }
                else
                {
                    s1 = s1 - i;
                }
            return s1;
        }
        public int tong2()
        {
            int n2, s2 = 0;
            Console.WriteLine("nhap n2: ");
            n2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n2; i++)
            {
                s2 = s2 + 1 / i;
            }
            return s2;
        }
        public int tong3()
        {
            int n3, s3 = 0;
            Console.WriteLine("nhap n3: ");
            n3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n3; i++)
            {
                s3 = s3 + i;
            }
            return s3;
        }
        public int tong4()
        {
            int n4, s4 = 0;
            Console.WriteLine("nhap n4: ");
            n4 = int.Parse(Console.ReadLine());
            for(int i =1; i<=n4; i++)
                if (n4 % i == 0)
                {
                    s4 = s4 + i;
                }
            return s4;
        }
        public void xuat()
        {
            Console.WriteLine("ket qua lan luot la {0} {1} {2} {3}", tong1(), tong2(), tong3(), tong4());
            Console.ReadLine();
        }
    }
}
