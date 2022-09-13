using System;

namespace Bai1
{
    class bai1
    {
        public class Student
        {
            private string? id;
            private string? name;
            private double pointMath;
            private double pointPhysics;
            private double pointChemistry;

            public Student()
            {
            }

            public Student(Student student)
            {
                id = student.id;
                name = student.name;
                pointMath = student.pointMath;
                pointPhysics = student.pointPhysics;
                pointChemistry = student.pointChemistry;
            }

            public Student(string id, string name, double pointMath, double pointPhysics, double pointChemistry)
            {
                this.id = id;
                this.name = name;
                this.pointMath = pointMath;
                this.pointPhysics = pointPhysics;
                this.pointChemistry = pointChemistry;
            }

            public void inputStudent()
            {
                Console.Write("Enter id: ");
                id = Console.ReadLine();
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter point math: ");
                pointMath = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter point physics: ");
                pointPhysics = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter point chemistry: ");
                pointChemistry = Convert.ToDouble(Console.ReadLine());
            }

            public double getSumPoint()
            {
                return pointMath + pointPhysics + pointChemistry;
            }

            public string getName()
            {
                return name;
            }
        }

        public class Admissions : Student
        {
            enum area
            {
                one,
                two,
                three
            }

            private int location;

            public Admissions()
            {
            }

            public void inputAdmissions()
            {
                inputStudent();
                Console.Write("Enter area(1-3): ");
                location = Convert.ToInt32(Console.ReadLine());
            }

            public double getSumPoint()
            {
                return base.getSumPoint() + location - 1;
            }

            public void toString()
            {
                Console.WriteLine("     - " + this.getName());
            }
        }

        public static void Main(string[] args)
        {
            int number;
            Console.Write("Enter number student: ");
            number = Convert.ToInt32(Console.ReadLine());
            List<Admissions> list = new List<Admissions>();
            for (int i = 0; i < number; i++)
            {
                Admissions admissions = new Admissions();
                admissions.inputAdmissions();
                list.Add(admissions);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter point standard: ");
            double point = Convert.ToDouble(Console.ReadLine());
            int check = 0;
            foreach (Admissions student in list)
            {
                if (student.getSumPoint() >= point)
                {
                    check++;
                    if (check == 1)
                    {
                        Console.WriteLine("List student admissionsed: ");
                    }

                    student.toString();
                }
            }
        }
    }
}