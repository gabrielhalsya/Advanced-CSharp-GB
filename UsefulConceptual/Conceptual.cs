using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulConceptual
{
    internal class Conceptual
    {
        //IsOperator, AsOperator
        class Shape { }
        class Triangle : Shape { }
        class Circle : Shape { }
        public static void AsOperator()
        {
            Shape shape = new();
            Circle circle = new Circle();
            Shape? convertToShape = circle as Shape;
            Console.WriteLine($"Conversion 'shape as Circle' produces {convertToShape}");
            Circle? convertCircle = shape as Circle;
            if (convertToShape != null)
            {
                Console.WriteLine($"COnversion  ' shape as Circle' produces null");
            }
            else
            {
                Console.WriteLine($"conversion 'circle as shape ' produces {convertCircle}");
            }
        }
        public static void IsOperator()
        {
            Circle circle = new();
            Triangle triangle = new();
            Console.WriteLine($"Is circle inherit shape : {circle is Shape}");
            Console.WriteLine($"Is triangle inherit shape : {triangle is Shape}");
        }

        //passingby value and reference/
        public static void PassingByValue(int x)
        {
            x *= 2;
            Console.WriteLine($"Body Passing By Value, x value : {x}");
        }

        public static void PassingByReference(ref int x)
        {
            x *= 2;
            Console.WriteLine($"Body Passing By Valueby ref : y value : {x}");
        }
    }
}
