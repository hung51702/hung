using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace demo { };

internal class Program
{
    // bai 1:
    //static void Main(string[] args)
    //{
    //    Console.Write("Nhap so nguyen duong a: ");
    //       int a = int.Parse(Console.ReadLine());
    //    Console.Write("Nhap so nguyên duong b: ");
    //       int b = int.Parse(Console.ReadLine());
    //       int o = a + b;
    //       int x = a - b;
    //       int y = a * b;
    //       float z = (float)a / b;
    //    Console.WriteLine("tong cua hai so: " + o);
    //    Console.WriteLine("hieu cua hai so: " + x);
    //    Console.WriteLine("tich cua hai so: " + y);
    //    Console.WriteLine("thuong cua hai so: " + z);
    //    Console.ReadKey();
    //}

    // bai 2:
    //static void Main(string[] args)
    //{
    //    Console.Write("Canh a cua hinh chu nhat: ");
    //       int a = int.Parse(Console.ReadLine());
    //    Console.Write("Canh b cua hinh chu nhat: ");
    //       int b = int.Parse(Console.ReadLine());
    //       int c = a * b;
    //       int d = (a + b) * 2;
    //    Console.WriteLine("dien tich cua hinh chu nhat: " + c);
    //    Console.WriteLine("chu vi cua hinh chu nhat :" + d);
    //    Console.ReadKey();
    //}

    // bai 3:
    //static void Main(string[] args)
    //{
    //       float x = 3.14f;
    //    Console.Write("duong kinh a cua kinh tron: ");
    //       int a = int.Parse(Console.ReadLine());
    //       int b = a / 2;
    //       float c = a * x;
    //       float d = b * b * x;
    //    Console.WriteLine("ban kinh hinh tron: " + b);
    //    Console.WriteLine("chu vi hinh tron: " + c);
    //    Console.WriteLine("dien tich hinh tron: " + d);
    //    Console.ReadKey();
    //}

    // bai 4:   
    //static void Main(string[] args)
    //{
    //    Console.Write("Ho va Ten: ");
    //       string hoTen = Console.ReadLine();
    //    Console.Write("Lop: ");
    //       string lop = Console.ReadLine();
    //    Console.Write("Diem trung binh hoc ki I: ");
    //       float a = float.Parse(Console.ReadLine());
    //    Console.Write("Diem trung binh hoc ki II: ");
    //       float b = float.Parse(Console.ReadLine());

    //       float c = (a + b * 2) / 3;    
    //    Console.WriteLine("Diem trung binh ca nam:" + c);
    //}

    // bai 5:
    //static void Main(string[] args)
    //{
    //    for (int i = 0; i < 2; i++)
    //    {
    //        Console.Write("Ho va ten nhan vien " + (i + 1 ) + ": ");
    //        string hoTen = Console.ReadLine();
    //        Console.Write("Gioi tinh: ");
    //        string gioiTinh = Console.ReadLine();
    //        Console.Write("Ngay sinh: ");
    //        string ngaySinh = Console.ReadLine();
    //        Console.Write("He so luong: ");
    //        string heSoLuong = Console.ReadLine();
    //        Console.Write("Luong co ban: ");
    //        float luongCoBan = float.Parse(Console.ReadLine());
    //        Console.Write("So nam lam viec: ");
    //        int soNamLamViec = int.Parse(Console.ReadLine());
    //        float phuCapNhanVien = 0;
    //        if ( soNamLamViec > 5)
    //        {
    //            phuCapNhanVien = luongCoBan / 2;
    //            Console.WriteLine("Phu cap nhan vien: " + phuCapNhanVien);

    //        }
    //        else
    //        {
    //            Console.WriteLine("Phu cap nhan vien: " + phuCapNhanVien);

    //        }
    //        Console.WriteLine();
    //    }

    //}

    // bai 6:
    //static void Main(string[] args)
    //{
    //    Console.Write("Nhap ngay: ");
    //    int ngay = int.Parse(Console.ReadLine());
    //    Console.Write("Nhap thang:");
    //    int thang = int.Parse(Console.ReadLine());
    //    Console.Write("Nhap nam:");
    //    int nam = int.Parse(Console.ReadLine());
    //    Console.WriteLine(">>-------------------------------<<");
    //    int ngayhomqua = ngay - 1;
    //    int ngayhomsau = ngay + 1;
    //    if (ngayhomqua == 0 && (thang % (float)2 == 0))
    //    {
    //        ngay = ngayhomqua + 30;
    //        thang = thang - 1;
    //        Console.WriteLine("Ngay hom qua : " + ngay + "/" + thang + "/" + nam);

    //    }
    //    else
    //    {
    //        ngay = ngayhomqua + 30;
    //        thang = thang - 1;
    //        if (thang == 2 && (nam % 4 == 0))
    //        {
    //            ngay = ngayhomqua + 29;

    //        }
    //        else
    //        {
    //            ngay = ngayhomqua + 28;

    //        }
    //        Console.WriteLine("Ngay hom qua : " + ngay + "/" + thang + "/" + nam);

    //    }
    //    Console.WriteLine("Ngay hien tai: " + ngay + "/" + thang + "/" + nam);
    //    if (ngayhomsau != 0 && (thang % (float)2 == 0))
    //    {

    //        ngay = ngayhomsau;
    //        thang = thang + 1;
    //        Console.WriteLine("Ngay hom sau : " + ngay + "/" + thang + "/" + nam);

    //    }
    //    else
    //    {
    //        ngay = ngayhomsau + 30;
    //        thang = thang + 1;
    //        if (thang == 2 && (nam % 4 == 0))
    //        {
    //            ngay = ngayhomsau + 29;

    //        }
    //        else
    //        {
    //            ngay = ngayhomsau + 28;

    //        }
    //        Console.WriteLine("Ngay hom sau : " + ngay + "/" + thang + "/" + nam);

    //    }
    //}
}
