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
            
            Console.WriteLine("\t Задание из 4 лабораторной: \t");
            B Ind = new B();
            for (int i = 0; i < 10; i++) Console.WriteLine("[{0}] {1}",i+1, Ind[i]);
            Console.WriteLine("");
            for (int i = 0; i < 10; i++) Console.WriteLine("[{0}] {1}",i+1, Ind[(short)i]);

            C<string>.F = "string";
            C<int>.F = 1010101010;

            Console.WriteLine("текст:{0}; число:{1}.", C<string>.F, C<int>.F);
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
    class C<T>
    {
        public static T F;  //статическое поле
    }
    public class B : A
    {
        private int a, b;
        private float d;
        public float[] array1;
        int[] arr = new int[] { 1, 7, 17, 77, 117, 177, 777, 1117, 1177, 1777 };
        int[] arr1;
        public int Length;
        public B()
        {
            arr1 = new int[] { 2, 29, 99, 229, 299, 999, 2229, 2299, 2999, 9999 };
        }

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

        public int this[int index]  //индексатор 1
        {
            set { arr[index] = value; }
            get { return arr[index]; }
        }
        public int this[short index1]  //индексатор 2  //вместо int приходится использовать short
        {
            get { return arr1[index1]; }
            set { arr1[index1] = value; }
        }
    }
}
//много кода, что бы сложнее было копипастить))"безопасность"
