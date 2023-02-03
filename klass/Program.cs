using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klass
{

    internal class Program
    {
        static void Main(string[] args)
        {
          
        }
    }

    class ComplexNumber
    {
        public int a ;
        public int b;
        public int c;
        

        static void PrintComplexNumber() 
        {
            ComplexNumber complexNumber = new ComplexNumber();
            complexNumber.a = Convert.ToInt32(Console.ReadLine());
            complexNumber.b = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine($"Opisaniye : {complexNumber.a}+{complexNumber.b}+i");
            Console.ReadKey();
        }

        static void GetMultiplicationByNumber() 
        {
            ComplexNumber complexNumber1 = new ComplexNumber();
            complexNumber1.a = Convert.ToInt32(Console.ReadLine());
            complexNumber1.b = Convert.ToInt32(Console.ReadLine());
            int ymA = complexNumber1.a*complexNumber1.c;
            int ymB = complexNumber1.b*complexNumber1.c;
            complexNumber1.c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ymnojenie : {ymA}+{ymB}+i");
        }

    }
}



