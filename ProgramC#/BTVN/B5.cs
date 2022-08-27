using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class MaTran
    {
        private int m, n;
        private int[,] matrix;

        public MaTran() { }
        public MaTran(MaTran maTran)
        {
            this.m = maTran.m;
            this.n = maTran.n;
            this.matrix = new int[m, n];
            for (int i = 0; i < maTran.m; i++)
            {
                for (int j = 0; j < maTran.n; j++)
                {
                    matrix[i, j] = maTran.matrix[i, j];
                }
            }
        }
        public MaTran(int h, int c)
        {
            this.m = h;
            this.n = c;
            matrix = new int[h, c];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        public void Nhap()
        {
            Console.Write("Enter row: ");
            m = Int32.Parse(Console.ReadLine());
            Console.Write("Enter columns: ");
            n = Int32.Parse(Console.ReadLine());
            matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Element: [" + i + ", " + j + "]: ");
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
        }
        public void Xuat()
        {
            int i, j;
            Console.WriteLine("Ma tran: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("[ " + matrix[i, j] + " ]");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void Sum(MaTran b)
        {
            MaTran z = new MaTran(m, n);
            if (m == b.m && n == b.n)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        z.matrix[i, j] = matrix[i, j] + b.matrix[i, j];
                    }
                }
                Console.WriteLine("Ma tran tong la: ");
                z.Xuat();
            }
            else
                Console.WriteLine("Khong the cong\n");
        }
        public void Sub(MaTran b)
        {
            MaTran z = new MaTran(m, n);
            if (m == b.m && n == b.n)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        z.matrix[i, j] = matrix[i, j] - b.matrix[i, j];
                    }
                }
                Console.WriteLine("Ma tran hieu la: ");
                z.Xuat();
            }
            else
                Console.WriteLine("Khong the tru\n");
        }
        public void Mul(MaTran b)
        {
            MaTran z = new MaTran(m, b.n);
            if (n == b.m)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < b.n; j++)
                    {
                        for (int k = 0; k < n; k++)
                            z.matrix[i, j] += matrix[i, k] * b.matrix[k, j];
                    }
                }
                Console.WriteLine("Ma tran tich la: ");
                z.Xuat();
            }
        }
        public void ChuyenVi(MaTran b)
        {
            Console.WriteLine("Ma tran chuyen vi cua ma tran: ");
            b.Xuat();
            for (int i = 0; i < b.m; i++)
            {
                for (int j = 0; j < b.n; j++)
                {
                    Console.Write("[ " + matrix[j, i] + " ]");
                }
                Console.WriteLine();
            }
        }
    }
}
