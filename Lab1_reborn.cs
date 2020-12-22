using System;

namespace Lab1_reborn
{
    class Program
    {
        static void Main(string[] args)
        {
            A ObjectA = new A();
            ObjectA.c = 55;
            Console.WriteLine("C= "+ObjectA.c);
        }
    }

    class A
    {
        private int a, b=100;
        public int c
        {
            get { return b; }
            set {
                a = value;
                b %= a;
                Console.WriteLine("b= "+b+" -промежуточное значение");
                b += a;
                Console.WriteLine("b2= "+b+" -промежуточное значение");
            }
        }
    }
}
