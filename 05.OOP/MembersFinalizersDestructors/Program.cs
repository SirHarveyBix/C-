using System;

namespace MembersFinalizersDestructors;
class Program
{
    static void Main(string[] args)
    {
        Members member1 = new Members();
        member1.Introducing(true);
        Console.ReadKey(); // to see the finalizer - but dosent work on mac
    }
}
