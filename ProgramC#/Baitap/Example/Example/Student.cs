using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Student
    {
        protected string name
        {
            get; set;
        }
        protected DateTime birth
        {
            get; set;
        }
        protected float pointProgram
        {
            get; set;
        }
        protected float pointSQL
        {
            get; set;
        }
        protected float pointWEB
        {
            get; set;
        }
        public Student()
        {
        }
        public Student(string name, DateTime birth, float pointProgram, float pointSQL, float pointWEB)
        {
            this.name = name;
            this.birth = birth;
            this.pointProgram = pointProgram;
            this.pointSQL = pointSQL;
            this.pointWEB = pointWEB;
        }


    }
}
