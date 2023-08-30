using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToaDo
{
    class ToaDoXY
    {
        int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        string tentoado;

        public string Tentoado
        {
            get { return tentoado; }
            set { tentoado = value; }
        }
        public ToaDoXY()
        {
            x = 0;
            y = 0;
            tentoado = "A";
        }
        public ToaDoXY(int x,int y,string tentoado)
        {
            x = this.x;
            y = this.y;
            tentoado = this.tentoado;
        }
        public void xuat()
        {
            Console.WriteLine("Tra ve thong tin theo mau");
            Console.WriteLine("{0}({1}:{2})", tentoado, x, y);
        }
    }
}
