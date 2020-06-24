using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClass
{
    class Student8
    {
        private int rollno;
        private string studentName;
        private int MarksInEng;
        private int MarksInMaths;
        private int MarksInScience;
        public void SetStudent(int no, string name,int marksEng,int marksMath,int marksSc)

        {

            rollno = no;
            studentName = name;
            MarksInEng = marksEng;
            MarksInMaths = marksMath;
            MarksInScience = marksSc;
        }

        public static double TotalMarks(double d1,double d2,double d3)
        {
            double totalmarks = d1 + d2 + d3;
            return totalmarks;
        }
        public static double percentage(double d1, double d2, double d3)
        {
            double percentage = (d1+d2+d3)/3;
            return percentage;
        }


    }

    class Calculate
    {
        static void Main()
        {
            Student8 s = new Student8();
            s.SetStudent(101, "Diwakar", 65, 75, 89);
            Console.WriteLine("Total marks is "+Student8.TotalMarks(65,75,89));
            Console.WriteLine("Percentage is " + Student8.percentage(65, 75, 89));

            Console.ReadKey();
        }
    }
}
