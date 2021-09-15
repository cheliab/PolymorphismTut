using System;

namespace Polymorphism.Examples
{
    public class BaseClass
    {
        public virtual void DoWork()
        {
            Console.WriteLine("Base class - DoWork()");
        }

        public virtual int WorkProperty => 0;
    }

    public class DerrivedClass : BaseClass
    {
        public override void DoWork()
        {
            Console.WriteLine("Derrived class - DoWork()");
        }

        public override int WorkProperty => 1;
    }
    
    public class VirtualMembersExample
    {
        public static void Start()
        {
            DerrivedClass B = new DerrivedClass();
            B.DoWork(); // вызовется метод дочернего класса

            BaseClass A = B;
            A.DoWork(); // так же вызовется метод дочернего класса
        }
    }
}