using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    /*Разработать структуру для решения линейного уравнения 0=kx+b. 
     *Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
     *Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. 
     *Осуществить использование экземпляра в программе.*/
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation { k = 100, b = -10 };
            equation.Root();
            Console.ReadKey();
        }
        struct Equation
        {
            public double k;
            public double b;
            public void Root()
            {
                double x = -b / k;
                Console.WriteLine("x = {0:f2}", x);
            }
        }
    }
}
