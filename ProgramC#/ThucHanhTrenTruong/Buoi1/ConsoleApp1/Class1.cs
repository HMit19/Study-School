using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong don thue xe: ");
            n = int.Parse(Console.ReadLine());
            List<tttx> demo = new List<tttx>();
            for (int i = 0; i < n; i++)
            {
                tttx a = new tttx();
                a.nhap();
                demo.Add(a);
            }
            foreach (tttx item in demo)
            {
                item.xuat();
            }
        }
    }
}
