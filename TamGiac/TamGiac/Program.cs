using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTamGiac HTG1 = new HinhTamGiac(3, 5, 6); // Tam giác thường
            HinhTamGiac HTG2 = new HinhTamGiac(-1, 2, 3); // Hình vi phạm ràng buộc
            HinhTamGiac HTG3 = new HinhTamGiac(8, 8, 8); // Tam giác đều
            HinhTamGiac HTG4 = new HinhTamGiac(6, 4, 6); // Tam giác cân
            HinhTamGiac HTG5 = new HinhTamGiac(11, 10, 13); // Tam giác thường
            HTG3.xuatTT();
            Console.ReadLine();
        }
    }
}
