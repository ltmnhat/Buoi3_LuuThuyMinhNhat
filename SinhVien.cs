using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_LuuThuyMinhNhat
{
    class SinhVien
    {
        int masv;

        public int Masv
        {
            get { return masv; }
            set
            {
                masv = value;
                {
                    if (Masv < 0)
                        throw new Exception("Nhao ma sinh vien lon hon 0!");
                }
            }

        }
        string hoten;

        public string Hoten
        {
            get { return hoten; }
            set
            {
                hoten = value;
                {
                    if (hoten == null)
                        throw new Exception("Ho ten sinh vien khong duoc rong!");
                }
            }
        }
        double diemLT;

        public double DiemLT
        {
            get { return diemLT; }
            set
            {
                diemLT = value;
                if (diemLT < 0 && diemLT > 10)
                    throw new Exception("Nhap diem co gia tri tu 0 den 10!");
            }
        }
        double diemTH;

        public double DiemTH
        {
            get { return diemTH; }
            set
            {
                diemTH = value;
                {
                    if (diemTH < 0 && diemTH > 10)
                        throw new Exception("Nhap diem co gia tri tu 0 den 10!");
                }
            }
        }
        public SinhVien()
        {
            masv = 2033210404;
            hoten = "Luu Thuy Minh Nhat";
            diemLT = 8;
            diemTH = 9;
        }
        public SinhVien(int masv, string hoten,double diemLT,double diemTH)
        {
            masv = this.masv;
            hoten = this.hoten;
            diemLT = this.diemLT;
            diemTH = this.diemTH;
        }
        double tinhDTB()
        {
            return (diemLT + diemTH) / 2;
        }
        public void nhapTT()
        {
            Console.Write("Nhap ma sinh vien: ");
            masv = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten sinh vien: ");
            hoten=Console.ReadLine();
            Console.Write("Nhap diem thi ly thuyet: ");
            diemLT=double.Parse(Console.ReadLine());
            Console.Write("Nhap diem thi thuc hanh: ");
            diemTH=double.Parse(Console.ReadLine());
        }
        public void xuatTT()
        {
            Console.WriteLine("MaSv \t\t TenSv \t\t\t DiemLT \t\t DiemTH \t\t DiemTb");
            Console.WriteLine("{0} \t {1} \t {2} \t\t\t {3} \t\t\t {4} ", masv, hoten, diemLT, diemTH, tinhDTB());
        }

    }
}
