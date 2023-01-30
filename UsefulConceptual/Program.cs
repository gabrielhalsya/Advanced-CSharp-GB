using System;
namespace UsefulConceptual
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Conceptual.IsOperator();
            Conceptual.AsOperator();

            ////pasing by val,ref
            //int x = 10;
            //Conceptual.PassingByValue(x);
            //Console.WriteLine($"Final value x = {x}");

            //int y = 10;
            //Conceptual.PassingByReference(ref y);
            //Console.WriteLine($"Final value y = {y}");
        }
    }
}
