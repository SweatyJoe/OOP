using System;

namespace Lab5_reborn
{
    class Program
    {
        static void Main(string[] args)
        {
            B Boble1 = new B { Value = 11};
            B Boble2 = new B { Value = 0 };
            Console.WriteLine("Введите второе число для сравнения");
            bool result = Boble1 & Boble2;
            Console.WriteLine(result);
            if(Boble1) Console.WriteLine(true); //=0
            else Console.WriteLine(false);      //!=0
        }
    }
    class B
    {
        public int Value
        {
            get;
            set;
        }

        public static bool operator &(B val1, B val2)
        {
            return (val1 & val2);
        }
        public static bool operator true(B val)
        {
            return val.Value == 0;
        }
        public static bool operator false(B val)
        {
            return val.Value != 0;
        }
    }
}
