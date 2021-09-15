using System;
using Polymorphism.Examples;
using Polymorphism.Examples.HideMembersExample;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // OverrideExample.Start();
            // VirtualMembersExample.Start();
            // HideBaseClassMembersWithNewMembers.Start();
            // PreventDerivedClassesFromOverridingVirtualMembers.Start();
            AccesBaseClassVirtualMembersFromDerivedClass.Start();
            
            Console.ReadLine();
        }
    }
}