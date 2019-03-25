﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class SinhVien
    {
        public String maSV;
        float toan;
        float ly;
        float hoa;
        //default constructor
        public SinhVien() {
            this.maSV = "01";
            this.toan = (float)7.5;
            this.ly = (float)8.5;
            this.hoa = (float)6.0;
                }
        //tham so hoa construcftor
        public SinhVien(String maSV, float toan, float ly, float hoa)
        {
            this.maSV = maSV;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        // ham nhap
        public void Nhap()
        {
            Console.WriteLine("Nhap ma sinh vien");
            this.maSV = Console.ReadLine();
            Console.WriteLine("Nhap diem toan");
            this.toan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly");
            this.ly = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa");
            this.hoa = float.Parse(Console.ReadLine());
        }
        public float diemtb()
        {
            return  ((this.toan + this.ly + this.hoa) / 3);
        }
        public void In()
        {
            Console.WriteLine("nhan vien co ma {0} co diem trung binh la: {1} ", this.maSV, this.diemtb());
        }
    }
}
