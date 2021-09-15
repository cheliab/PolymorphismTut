using System;

namespace Polymorphism.Examples
{
    public class A
    {
        public virtual void DoWork()
        {
            Console.WriteLine("A - DoWork");
        }
    }

    public class B : A
    {
        public override void DoWork()
        {
            Console.WriteLine("B - DoWork");
        }
    }

    public class C : B
    {
        public sealed override void DoWork()
        {
            Console.WriteLine("C - DoWork");
        }
    }

    public class D : C
    {
        public new void DoWork()
        {
            Console.WriteLine("D - DoWork");
        }
    }
    
    public class PreventDerivedClassesFromOverridingVirtualMembers
    {
        public static void Start()
        {
            D d = new D();
            d.DoWork(); // D - DoWork

            C c = d;
            c.DoWork(); // C - DoWork

            B b = c;
            b.DoWork(); // C - DoWork

            A a = b;
            a.DoWork(); // C - DoWork
        }
    }
}