using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS
{
     class StaticInheritanceA 
    {
        public StaticInheritanceA()
        {
            Console.WriteLine("Constructor A");
        }
         static StaticInheritanceA()
        {
            Console.WriteLine("Static Constructor A");
        }
    }
     class  StaticInheritanceB : StaticInheritanceA
    {
        public StaticInheritanceB()
        {
            Console.WriteLine("Constructor B");
        }
        static StaticInheritanceB()
        {
            Console.WriteLine("Static Constructor B");
        }
    }
}
