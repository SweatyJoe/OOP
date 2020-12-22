using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            A ObjectA = new A();
            Console.WriteLine("Введите a");
            ObjectA.c=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("С= " + ObjectA.c);

            Random rnd = new Random();
            int value = rnd.Next();
            B ObjectB = new B(value, 50); //наследуемый конструктор
            B ObjectB1 = new B();      //собственный
        }
    }

    public class A
    {
        private int a, b;
        public int c
        {
            get { return b; }
            set
            {
                a = value;
                b %= a;
                Console.WriteLine("b= " + b + " -промежуточное значение");
                b += a;
                Console.WriteLine("b2= " + b + " -промежуточное значение");
            }
        }
        public A()  //конструктор лего
        {
            a = c;
            Console.WriteLine("a в конструкторе= " + a);
        }
        public A(int a, int b)
        {
            a = this.a;
            b = this.b;
        }
    }
    
    public class B : A
    {
        private int d, a, b;
        public B(int a, int b):base (a,b)  //наследуемый конструктор
        {
            this.a = a;
            this.b = b;
            c2 = a;
            Console.WriteLine("D after managing operator (c2): "+c2);
        }
        public int c2  //использование a,b,d + оператор
        {
            get { return d; }
            set {
                d = value;
                if (d > 50) d += b;
                else d += a;
            }
        }
        public B()
        {
            Console.WriteLine("Empty constryktor");
        }
    }
}
