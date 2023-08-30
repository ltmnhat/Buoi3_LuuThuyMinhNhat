using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    class HinhTamGiac
    {
        private double ma, mb, mc;

        public HinhTamGiac()
        {
            ma = mb = mc = 0;
        }

        public HinhTamGiac(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                ma = mb = mc = 0;
            }
            else
            {
                ma = a;
                mb = b;
                mc = c;
            }
        }

        public double Ma
        {
            get { return ma; }
            set
            {
                if (value > 0 && value + mb > mc && value + mc > mb)
                    ma = value;
            }
        }

        public double Mb
        {
            get { return mb; }
            set
            {
                if (value > 0 && value + ma > mc && value + mc > ma)
                    mb = value;
            }
        }

        public double Mc
        {
            get { return mc; }
            set
            {
                if (value > 0 && value + ma > mb && value + mb > ma)
                    mc = value;
            }
        }

        public double TinhChuVi()
        {
            return ma + mb + mc;
        }

        public double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
        }

        public string KieuTamGiac()
        {
            if (ma == mb && mb == mc)
                return "Tam giac đeu";
            else if (ma == mb || mb == mc || ma == mc)
                return "Tam giac can";
            else if (ma != mb && mb != mc && ma != mc)
                return "Tam giac thuong";
            else
                return "Khong phai tam giac";
        }
        public void xuatTT()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5}", ma, mb, mc, KieuTamGiac(), TinhChuVi(), TinhDienTich());
        }
    }
}
