using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    public class Student
    {
        private string name;
        private string birth;
        private float scoreSQL;
        private float scoreProgram;
        private float scoreWEB;

        public Student()
        {
        }

        public Student(string name, string birth, float scoreSQL, float scoreProgram, float scoreWEB)
        {
            this.name = name;
            this.birth = birth;
            this.scoreSQL = scoreSQL;
            this.scoreProgram = scoreProgram;
            this.scoreWEB = scoreWEB;
        }
        public void intputStudent()
        {
            Console.Write("Enter name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter birth: ");
            this.birth = Console.ReadLine();
            Console.Write("Enter Score SQL: ");
            this.scoreSQL = float.Parse(Console.ReadLine());
            Console.Write("Enter Score Program: ");
            this.scoreProgram = float.Parse(Console.ReadLine());
            Console.Write("Enter Score WEB: ");
            this.scoreWEB = float.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
        public float getScoreAVG()
        {
            return (scoreSQL + scoreWEB + scoreWEB) / 3;
        }
        public Boolean checkUnder5()
        {
            return scoreSQL >= 5 && scoreProgram >= 5 && scoreWEB >= 5;
        }
        public string toString()
        {
            return "Name: " + this.name + "\n" + "Birth: " + this.birth + "\n"
                + "Score SQL: " + this.scoreSQL + "\n" + "Score Program: " +this.scoreProgram + "\n" + "Score WEB: " + this.scoreWEB;
        }
    } 
    public class ListStudent
    {
        private int number;
        List<Student> listStudent;

        public ListStudent()
        {
        }

        public void inputStudent()
        {
            Console.Write("Input number student: ");
            number = Convert.ToInt32(Console.ReadLine());
            listStudent = new List<Student>(number);
            for (int i = 0; i < number; i++)
            {
                Student student = new Student();
                student.intputStudent();
                listStudent.Add(student);
            }
        }

        public void showStudent()
        {
            foreach (Student items in listStudent)
            {
                Console.WriteLine(items.toString());
            }
            Console.WriteLine();
        }
        public List<Student> getListStudent()
        {

            return new List<Student>(listStudent);
        }
        public void sortByID()
        {
            listStudent.Sort();
        }
        public int getCountDk1()
        {
            int res = 0;
            foreach (Student items in listStudent)
            {
                if (items.getScoreAVG() >= 8)
                {
                    res++;
                }
            }
            return res;
        }
        public int getCountDk2()
        {
            int res = 0;
            foreach (Student items in listStudent)
            {
                if (items.getScoreAVG() >= 8 && items.checkUnder5())
                {
                    res++;
                }
            }
            return res;
        }
    }

}
