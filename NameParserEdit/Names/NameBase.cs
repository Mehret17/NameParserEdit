using System;
using System.Collections.Generic;
using System.Text;

namespace NameParserEdit.Names
{
    abstract class NameBase
    {
        //field
        private readonly string _whichName;

        // a pulbic property with a getter and a private setter 
        public string Name { get; protected set; }


        //constructor
        public NameBase(string whichName)
        {
            _whichName = whichName;
        }

        // create a method for getting the first name
        public virtual void GetName()
        {
            Console.WriteLine($"Enter your {_whichName} name");
            Name = Console.ReadLine();

        }

        public abstract void PrintName();
    }
}
