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
            Random rnd = new Random();
            int value = rnd.Next(1, 10);  //нотка рандома (по факту заменяет 'а' в классе 'B') 

            B ObjectArray = new B(value, 9.92f); //конструктор с массивом
            foreach (var i in ObjectArray.array1) Console.WriteLine(i + "\t");

            Console.WriteLine();
            B ObjectInd = new B(10);
            for(int i = 0; i < ObjectInd.Length; i++)
            {
                ObjectInd[i] = Convert.ToInt32(Console.ReadLine());
            }
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
                b += a;
            }
        }
        public A() {}
        public A(int a, int b)
        {
            a = this.a;
            b = this.b;
        }
        public A(int a)
        {
            a = this.a;
        }
    }

    public class B : A
    {
        private int a, b;
        private float d;
        public float[] array1;
        int[] arr;
        public int Length;

        public B(int a, int b, float d) : base(a, b)  //наследуемый конструктор
        {
            this.a = a;
            this.b = b;
            c2 = a;
            Console.WriteLine("D after managing operator (c2): " + c2);
        }
        public float c2  //использование a,b,d + оператор
        {
            get { return d; }
            set
            {
                d = value;
                if (d > 50) d -= b;
                else d += a;
            }
        }
        public B(float d, int a) : base(a)   //собственный конструктор
        {
            this.a = a;
            Console.WriteLine("передача управления в собственный конструктор!");
        }
        public B(int a, float d) : this(d, a)   //конструктор инициализации массива
        {
            Console.WriteLine("Размерность: " + a);
            array1 = new float[a];
            c2 = a;
            for (int j = 0; j < array1.Length; j++)
            {
                array1[j] = c2 * j;
            }
        }

        public int this[int index]
        {
            set { arr[index] = value; }
            get { return arr[index]; }
        }
        public Index(int size)
        {
            arr = new int[size];
            Length = size;
        }

    }
}
