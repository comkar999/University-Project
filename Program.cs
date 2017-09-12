using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter R to Read the Data (or) Enter G to get the Data");
            char readorget=char.Parse( Console.ReadLine());
            Student s1 = new Student();
            if (readorget=='r')
            {
                
                s1.readStudentData();
                Console.WriteLine("Do you wanna get the data");
                s1.printStudentData();
            }
            else
            {
                s1.printStudentData();

            }
        }
    }

    
}
