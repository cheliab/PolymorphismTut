using System;

namespace Polymorphism.Examples
{
    public class Base
    {
        public virtual void DoWork()
        {
            Console.WriteLine("Base - DoWork()");
        }
    }

    public class Derived : Base
    {
        public override void DoWork()
        {
            Console.WriteLine("Derived - DoWork()");
            base.DoWork(); // вызывается метод родительского класса
        }
    }
    
    public class AccesBaseClassVirtualMembersFromDerivedClass
    {
        public static void Start()
        {
            Derived d = new Derived();
            d.DoWork();            
        }
    }
}