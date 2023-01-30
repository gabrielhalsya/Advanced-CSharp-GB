using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Interface
{
    internal interface Ivehicle<T>
    {
        T Getcolor(T color);
        public void Infovehicle();

    }

    class Car<T> : Ivehicle<T>
    {
        public T Getcolor(T color)
        {
            return color;
        }

        public void Infovehicle()
        {
            Console.WriteLine("This is a car");
        }
    }
}
