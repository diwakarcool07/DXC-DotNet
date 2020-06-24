using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClass
{
    class Student3
    {
        public int rollno;
        public string sName;
        public static string Class; //static variable
        public static string sem;//static variable
        public static string branch;
        public void Details()
        {
            Console.WriteLine("RollNo: " + rollno);
            Console.WriteLine("Sname: " + sName);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Sam: " + sem);
            Console.WriteLine("branch: " + branch);
        }

        int[] marks = new int[5] { 56, 98, 45, 78, 63 };
        public void displayresult()
        {
            
            for(int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("You are fail");
                    break;
                }
                else
                {
                    Console.WriteLine("you are pass");
                }

            }
        }

    }

    class Student_Details
    {
        static void Main()
        {
            Student3 s3 = new Student3();
            s3.rollno = 102;
            s3.sName = "Joy";
            Student3.Class = "BE";
            Student3.sem = "8";
            Student3.branch = "CSE";
            s3.Details();
            s3.displayresult();
           
             Console.ReadKey();

        }
    }
}
