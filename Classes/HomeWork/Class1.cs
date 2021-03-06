using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Rectangle
    {
        double _side1, _side2;  // Поля класса

        public double Area { get { return AreaCalculator(); } }
        public double Perimetr { get { return PerimeterCalculator(); } }

        public Rectangle(double val1, double val2)
        {
            _side1 = val1;
            _side2 = val2;
        }

        private double AreaCalculator()
        {
            return _side1 * _side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (_side1 + _side2);
        }
    }

    /*class Class1
    {
        static void Main()
        {
            Console.WriteLine("Type value of side and wight:");

            double val1 = 0, val2 = 0;

            val1 = double.Parse(Console.ReadLine());
            val2 = double.Parse(Console.ReadLine());

            //int? val = null;//ссылочный? тип данных
            //int val = 0;
            //val = Console.Read();
            //Console.WriteLine((char)val);

            Rectangle instance = new Rectangle(val1, val2);

            string s = String.Format("Area: {0} \nPerimeter: {1}", instance.Area, instance.Perimetr);
            Console.WriteLine(s);
            //Console.WriteLine("Perimeter: {0}", instance.Perimetr);

            Console.WriteLine($"Area: {instance.Area} \nPerimeter: {instance.Perimetr}");

            Console.ReadKey();
        }
}*/
}
