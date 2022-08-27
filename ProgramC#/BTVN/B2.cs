using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    internal class PhanSo
    {
        private int TuSo;
        private int MauSo;

        public int TuSo1 { get => TuSo; set => TuSo = value; }
        public int MauSo1 { get => MauSo; set => MauSo = value; }

        public PhanSo()
        {
            TuSo1 = 0;
            MauSo1 = 1;
        }
        public PhanSo(int TuSo, int MauSo)
        {
            this.TuSo1 = TuSo;
            this.MauSo1 = MauSo;
        }
        public void nhap()
        {
            Console.WriteLine("------------------------------");
            Console.Write("Nhap tu: ");
            this.TuSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap mau: ");
            this.MauSo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------");
        }
        public void xuat()
        {
            Console.WriteLine("Tu so/Mau so: {0}/{1}", this.TuSo1, this.MauSo1);
            Console.WriteLine("------------------------------");
        }
        public void xuat(PhanSo ps)
        {
            Console.WriteLine("Tu so/Mau so: {0}/{1}", ps.TuSo1, ps.MauSo1);
            Console.WriteLine("------------------------------");
        }
        public int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }
        public void RutGon()
        {
            int t = UCLN(TuSo1, MauSo1);
            TuSo1 /= t;
            MauSo1 /= t;
        }
        public void rut_gonPhanSo()
        {
            int uc = UCLN(TuSo1, MauSo1);
            TuSo1 /= uc;
            MauSo1 /= uc;
        }

        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo((ps1.TuSo1 * ps2.MauSo + ps1.MauSo * ps2.TuSo), ps1.MauSo * ps2.MauSo);
            ps.rut_gonPhanSo();
            return ps;
        }
        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo((ps1.TuSo * ps2.MauSo - ps1.MauSo * ps2.TuSo), ps1.MauSo * ps2.MauSo);
            ps.rut_gonPhanSo();
            return ps;
        }
        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo((ps1.TuSo * ps2.TuSo), (ps1.MauSo * ps2.MauSo));
            ps.rut_gonPhanSo();
            return ps;
        }
        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo((ps1.TuSo * ps2.MauSo), (ps1.MauSo * ps2.TuSo));
            ps.rut_gonPhanSo();
            return ps;
        }
    }
}
