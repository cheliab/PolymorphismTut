using System;

namespace Polymorphism.Examples.HideMembersExample
{
    public class BaseClass
    {
        public int WorkField;
        
        public void DoWork()
        {
            WorkField++;
            
            Console.WriteLine("BaseClass - DoWork");
        }

        public int WorkProperty
        {
            get { return 0; }
        }
    }

    public class DerivedClass : BaseClass
    {
        public new int WorkField;

        public new void DoWork()
        {
            WorkField--;
            
            Console.WriteLine("DerivedClass - DoWork");
        }

        public new int WorkProperty
        {
            get { return 1; }
        }
    }
    
    public class HideBaseClassMembersWithNewMembers
    {
        public static void Start()
        {
            DerivedClass B = new DerivedClass();
            B.DoWork(); // вызывается новый метод

            BaseClass A = B;
            A.DoWork(); // вызывается старый метод
        }
    }
}