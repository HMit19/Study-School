using System;

namespace Example
{

    public class ListStudent : Student
    {
        List<Student> listStudent;
        public ListStudent()
        {
            listStudent = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if(student == null)
            {
                throw new Exception("Student is null");
            }
            listStudent.Add(student);
        }

        public List<Student> getListStudent()
        {
            return listStudent;
        }

    }

}