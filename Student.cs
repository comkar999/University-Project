using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
   public  class Student
    {
        public int studentid;
        public string firstname;
        public string lastname;
        public string degree;
        public string branch;
        public int StudentId
        {
            get
            {
                return this.studentid;
            }
            set
            {
                this.studentid = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }
        }

        
        public string LastName {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
                }
        public string Degree
        {
            get
            {
                return this.degree;
            }
            set
            {
                this.degree = value;
            }
        }

        public string Branch
        {
            get
            {
                return this.branch;
            }
            set
            {
                this.branch = value;
            }
        }

        List<Student> listStudents = new List<Student>();
        public  void readStudentData()
        {
            

            Student s = new Student();
            Console.WriteLine("Enter Student Id");
            s.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student First Name ");
            s.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name ");
            s.LastName = Console.ReadLine();
            Console.WriteLine("Enter Student Degree ");
            s.Degree = Console.ReadLine();
            Console.WriteLine("Enter Student Branch");
            s.Branch = Console.ReadLine();

            listStudents.Add(s);
            Console.WriteLine("Data is Stored");
            
            
        }

        public void printStudentData()
        {
            foreach(Student s in listStudents)
            {
                Console.WriteLine("Student Id: " + s.StudentId);
                Console.WriteLine("Student First Name: " + s.FirstName);
                Console.WriteLine("Student Last Name: " + s.LastName);
                Console.WriteLine("Student Degree: " + s.Degree);
                Console.WriteLine("Student Branch: " + s.Branch);
            }

            Console.ReadLine();
        }
    }
}
