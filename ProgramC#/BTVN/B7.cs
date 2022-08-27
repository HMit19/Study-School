using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class SinhVien
    {
        private string id;
        private string? name;
        private string? birth;
        private float scoreProgram;
        private float scoreSQL;

        public string Id { get => id; set => id = value; }

        public SinhVien() { }

        public SinhVien(string id, string name, string birth, float scoreProgram, float scoreSQl)
        {
            this.Id = id;
            this.name = name;
            this.birth = birth;
            this.scoreProgram = scoreProgram;
            this.scoreSQL = scoreSQl;
        }

        public float scoreAVG()
        {
            return (scoreProgram + scoreSQL) / 2;
        }
        public void inputSinhVien()
        {
            Console.Write("Enter ID: ");
            this.Id = Console.ReadLine();
            Console.Write("Enter name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter birth: ");
            this.birth = Console.ReadLine();
            Console.Write("Enter Score Program: ");
            this.scoreProgram = float.Parse(Console.ReadLine());
            Console.Write("Enter Score SQL: ");
            this.scoreSQL = float.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public string toString()
        {
            return "ID: " + Id + " - Name: " + this.name + " - " + "Birth: " + this.birth + " - "
                + "Score Program: " + this.scoreProgram + " - " + "Score CSDL: " + this.scoreSQL;
        }
    }

    public class DanhSachSinhVien
    {
        int number;
        List<SinhVien> listSinhVien;
        public DanhSachSinhVien() { }
        public void inputListStudent()
        {
            Console.Write("Nhap so sinh vien: ");
            number = int.Parse(Console.ReadLine());
            listSinhVien = new List<SinhVien>();
            for (int i = 0; i < number; i++)
            {
                SinhVien sinhVien = new SinhVien();
                Console.WriteLine("Sinh vien {0}", i + 1);
                sinhVien.inputSinhVien();
                listSinhVien.Add(sinhVien);
            }
        }

        public void outputListSinhVien()
        {
            foreach (SinhVien sinhVien in listSinhVien)
            {
                Console.WriteLine(sinhVien.toString());
            }
            Console.WriteLine();
        }
        public void outputSinhVienScoreMore(float score)
        {
            foreach (SinhVien sinhVien in listSinhVien)
            {
                if (sinhVien.scoreAVG() > score)
                {
                    Console.WriteLine(sinhVien.toString());
                }
            }
        }
        public void sortStudentByID()
        {
            var listStudent = listSinhVien.OrderBy(x => x.Id);
            foreach (var student in listStudent)
            {
                Console.WriteLine(student.toString());
            }
        }
    }
}
