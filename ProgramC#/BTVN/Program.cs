
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{

    public class Program
    {
        public class Ex1
        {
            public Ex1()
            {
                ListStudent list = new ListStudent();
                list.inputStudent();
                list.showStudent();
                Console.WriteLine("So sinh vien duoc lam khoa luan tot nghiep la:{0} \n", list.getCountDk2());
                Console.WriteLine("So sinh vien duoc lam chuyen de tot nghiep la: {0}", list.getCountDk1());
                Console.WriteLine();
            }
        }

        public class Ex2
        {
            public Ex2()
            {
                PhanSo ps1 = new PhanSo();
                Console.WriteLine("Nhap phan so thu nhat: ");
                ps1.nhap();
                Console.WriteLine("Phan so vua nhap la: ");
                ps1.xuat();
                Console.WriteLine("Phan so sau khi rut gon la: ");
                ps1.rut_gonPhanSo();
                ps1.xuat(ps1);
                Console.WriteLine("Nhap phan so thu hai: ");
                PhanSo ps2 = new PhanSo();
                ps2.nhap();
                Console.WriteLine("Phan so vua nhap la: ");
                ps2.xuat();
                Console.WriteLine("Phan so sau khi rut gon la: ");
                ps2.rut_gonPhanSo();
                ps2.xuat(ps2);
                Console.WriteLine("\n------------------------------");
                PhanSo ps = new PhanSo();
                ps = ps1 + ps2;
                Console.Write("\tTong hai phan so:");
                ps.xuat();
                ps = ps1 - ps2;
                Console.Write("\tHieu phan so thu nhat va phan so thu hai la: ");
                ps.xuat();
                ps = ps1 * ps2;
                Console.Write("\tTich hai phan so: ");
                ps.xuat();
                ps = ps1 / ps2;
                Console.Write("\tThuong phan so thu nhat va phan so thu hai la: ");
                ps.xuat();
                Console.WriteLine();
            }

        }

        public class Ex3
        {
            public Ex3()
            {
                Diem d1 = new Diem();
                d1.nhap();
                d1.xuat();
                Diem d2 = new Diem();
                d2.nhap();
                d2.xuat();
                Console.WriteLine("Khoang cach hai diem la: {0}", d1.KhoangCach(d1, d2));
                Console.WriteLine();
            }
        }

        public class Ex4
        {
            public Ex4()
            {
                Mang m = new Mang();
                m.Input();
                m.Print();
                m.sapxep(0);
                Console.WriteLine("\nMang sau khi sap xep tang dan: ");
                m.Print();

                m.sapxep(1);
                Console.WriteLine("\nMang sau khi sap xep giam dan: ");
                m.Print();
                Console.Write("\nNhap gia tri can tim: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nVi tri phan tu can tim la: " + (m.Search(k) != -1 ? m.Search(k) : "!Khong ton tai"));
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        class Ex5
        {
            public Ex5()
            {
                MaTran mt1 = new MaTran();
                Console.WriteLine("\nNhap ma tran 1: ");
                mt1.Nhap();
                mt1.Xuat();
                MaTran mt2 = new MaTran();
                Console.WriteLine("\nNhap ma tran 2: ");
                mt2.Nhap();
                mt2.Xuat();

                MaTran[] tg = new MaTran[4];
                for (int i = 0; i < 4; i++)
                {
                    tg[i] = new MaTran(mt1);
                }
                tg[0].Sum(mt2);
                tg[1].Sub(mt2);
                tg[2].Mul(mt2);
                tg[3].ChuyenVi(tg[3]);

            }
        }

        class Ex6
        {
            public Ex6()
            {
                Employees employees = new Employees();
                employees.inputEmployees();
                employees.RollSalary();
                employees.showEmployees();
                Console.WriteLine();
            }
        }
        class Ex7
        {
            public Ex7()
            {
                DanhSachSinhVien dssv = new DanhSachSinhVien();
                dssv.inputListStudent();
                Console.WriteLine("-----------------Danh sach sinh vien-------------------");
                dssv.outputListSinhVien();
                Console.WriteLine("-----------------Danh sach sinh vien score more 8-------------------");
                dssv.outputSinhVienScoreMore(8);
                Console.WriteLine("-----------------Danh sach sinh vien sap xep tang theo id-------------------");
                dssv.sortStudentByID();
            }
        }
        class Ex8
        {
            public Ex8()
            {
                SachPlus sach = new SachPlus();
                sach.intputSach();
                Console.Write("\nEnter QR Find: ");
                int qr = int.Parse(Console.ReadLine());
                int check = sach.checkQRCode(qr);
                if (check != 0)
                {
                    Console.WriteLine("So luong ton: {0}", check);
                }
                else
                {
                    Console.WriteLine("!Khong ton tai sach");
                }
            }
        }

        static void Main(string[] args)
        {
            int choose = 1;
            do
            {
                Console.WriteLine("--------------------------------Menu-----------------------------");
                Console.WriteLine("1 - Run Ex1 Quan li sinh vien");
                Console.WriteLine("2 - Run Ex2 Phan so");
                Console.WriteLine("3 - Run Ex3 Diem");
                Console.WriteLine("4 - Run Ex4 Mang");
                Console.WriteLine("5 - Run Ex5 Ma tran");
                Console.WriteLine("6 - Run Ex6 Nhan vien");
                Console.WriteLine("7 - Run Ex7 Quan li sinh vien phus: ");
                Console.WriteLine("8 - Run Ex7 Quan li sach: ");
                Console.WriteLine("0 - To End");
                Console.WriteLine("----------------------------------------------------------------");
                Console.Write("Input your choose: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: new Ex1(); break;
                    case 2: new Ex2(); break;
                    case 3: new Ex3(); break;
                    case 4: new Ex4(); break;
                    case 5: new Ex5(); break;
                    case 6: new Ex6(); break;
                    case 7: new Ex7(); break;
                    case 8: new Ex8(); break;
                    case 0: choose = 0; break;
                }
            } while (choose != 0);
        }
    }
}