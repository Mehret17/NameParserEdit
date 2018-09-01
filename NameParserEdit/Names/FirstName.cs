using System;
using System.Collections.Generic;
using System.Text;

namespace NameParserEdit.Names
{
    class FirstName : NameBase
    {
        //calling a method on base class
        public FirstName() : base("first")
        {

        }

        public override void PrintName()
        {
            foreach (var letter in Name)
            {
                Console.WriteLine(letter);
           }
        }
    }
}
