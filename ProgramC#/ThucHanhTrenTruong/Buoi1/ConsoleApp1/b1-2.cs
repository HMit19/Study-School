using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class tttx
    {
        private string hoTen;
        private int soGio;
        private int loaiXe;

        public tttx()
        {
        }

        public tttx(string hoTen, int soGio, int loaiXe)
        {
            this.hoTen = hoTen;
            this.soGio = soGio;
            this.loaiXe = loaiXe;
        }
        public void nhap()
        {
            Console.Write("Nhap ten nguoi thue: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap so gio thue: ");
            soGio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap loai xe: \n");
            Console.WriteLine("    - 1, Xe tai");
            Console.WriteLine("    - 2, Xe du lich");
            Console.WriteLine("    Choose: ");
            loaiXe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        public void xuat()
        {
            Console.Write("Ten: " + hoTen + " - So gio: " + soGio + " - Thanh tien: " + getTien() + "\n");
        }

        private String getTien()
        {
            long res = 0;
            if (loaiXe == 1)
            {
                for (int i = 1; i <= soGio; i++)
                {
                    if (i == 1) res += 250000;
                    else i += 70000;
                }
            }
            else
            {
                for (int i = 1; i <= soGio; i++)
                {
                    if (i == 1) res += 220000;
                    else i += 85000;
                }
            }
            return res.ToString();
        }
    }
}
