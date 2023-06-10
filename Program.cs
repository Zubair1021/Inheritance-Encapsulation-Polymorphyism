using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8T2
{
    class Program
    { 
        public class Person
        {
            protected string name;
            protected string address;

            public Person(string name , string address)
            {
                this.name = name;
                this.address = address;
            }
            public string getname()
            {
                return name;
            }
            public string getaddress()
            {
                return address;
            }
            public void setaddress(string address)
            {
                this.address = address;
            }
            public virtual string tostring()
            {
                return "Person[" +" Name: " + name + "\t\t" + "Address: " + address + "]";
            }
        }
        public class Student : Person
        {
            private string program;
            private int year;
            private double fee;

            public Student(string name,string address,string program,int year,double fee) : base (name,address)
            {
                this.program = program;
                this.year = year;
                this.fee = fee;
            }
            public string getprogram()
            {
                return program;
            }
            public void setprogram(string program)
            {
                this.program = program;
            }
            public void setyear(int year)
            {
                this.year = year;
            }
            public void setfee(double fee)
            {
                this.fee = fee;
            }
            public int getyear()
            {
                return year;
            }
            public double getfee()
            {
                return fee;
            }
            public override string tostring()
            {
                return "STUDENT [ Person "+"Name: " + name + "\t\t" + "Address: " + address + " ]\t\t" + "Program: " + program + "\t\t" + "year: " + year + "\t\t" + "fee: " + fee +"]";
            }

        }
        public class staff : Person
        {
            private string school;
            private double pay;

            public staff(string name, string address, string school, double pay) : base(name, address)

            {
                this.school = school;
                this.pay = pay;
            }
            public void setschool(string school)
            {
                this.school = school;
            }
            public string getschool()
            {
                return school;
            }
            public void setpay(double pay)
            {
                this.pay = pay;
            }
            public double getpay()
            {
                return pay;
            }
            public override string tostring()
            {
                return "Staff[ Person ["+"Name: " + name + "\t\t" + "Address: " + address + "]\t\t" + "School: " + school + "\t\t" + "Pay: " + pay+ "]";
            }
        }

        
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Student s1 = new Student("Ali", "Lahore", "BSCS", 2, 5000); list.Add(s1);
            Student s2 = new Student("Ahmed", "Gujrat", "BSCS", 2, 5000); list.Add(s2);

            staff p1 = new staff("Saad", "Lahore","Peak",4300); list.Add(p1);
            staff p2 = new staff("Hamza", "Lahore","Beachon",5000); list.Add(p2);

            foreach(Person p in list)
            {
                Console.WriteLine(p.tostring());

            }
            Console.ReadKey();

        }
    }
}
