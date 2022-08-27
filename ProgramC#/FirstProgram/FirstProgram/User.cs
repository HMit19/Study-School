using System;

namespace model{
    public class User
    {
        private string name;
        private int age;
        private string address;

        public User() { }
        public User(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getAddress()
        {
            return address;
        }
    }
}