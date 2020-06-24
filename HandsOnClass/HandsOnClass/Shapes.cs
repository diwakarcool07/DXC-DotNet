using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClass
{
    class Shapes
    {
        public void CalculateArea(float x)
        {
            Console.WriteLine("Area of Square is " + x * x + " sq units");
        }
        public void CalculateArea(double r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area of Circle is " + area+ " sq units");
        }

        public void CalculateArea(double x,double y)
        {
            Console.WriteLine("Area of Reactangle is " + x * y + " sq units");
        }

        public void CalculateArea(float height,float Base)
        {
            Console.WriteLine("Area of Traiangle is " + (height*Base)/2 + " sq units");
        }

    }
    class Test_Area
    {
        static void Main()
        {
            Shapes sp = new Shapes();
            sp.CalculateArea(2.1);
            sp.CalculateArea(2,8);
            sp.CalculateArea(24,87);
            sp.CalculateArea(2.6,9.17);
            Console.ReadKey();

        }
    }
}
