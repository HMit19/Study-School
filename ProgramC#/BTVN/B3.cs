using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class Diem
    {
        private double x;
        private double y;

        public Diem()
        {
            this.x = 0;
            this.y = 0;
        }

        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void nhap()
        {
            Console.Write("Nhap x: ");
            this.x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap y: ");
            this.y = Convert.ToDouble(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Diem co toa do (x, y) = ({0}, {1})", this.x, this.y);
        }
        public double KhoangCach(Diem d1, Diem d2)
        {
            double kc;
            kc = Math.Sqrt(1.0*(d1.x - d2.x) * (d1.x - d2.x) + (d1.y - d2.y) * (d1.y - d2.y));
            return kc;
        }
    }
}
