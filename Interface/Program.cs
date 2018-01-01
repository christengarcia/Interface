using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.MyNumber = 5;
            a.InterfaceMethod();
            Console.Read();
        }
    }

    interface IShape
    {
        int MyNumber
        {
            get;
            set;
        }
        void InterfaceMethod();
    }
}
