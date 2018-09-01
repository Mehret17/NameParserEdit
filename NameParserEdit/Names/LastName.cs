using System;
using System.Collections.Generic;
using System.Text;

namespace NameParserEdit.Names
{
    class LastName : NameBase // class lastname inherits from namebase
    {

      public FirstName FirstName { get; }

      public LastName() : base("last")// just calls the contructor from namebase does not do anyhtin
        {}

          public override void PrintName()
        {
            var lastNameWithSpaces = "";

            foreach (var letter in Name.ToUpper())
            {
                lastNameWithSpaces += letter + " ";

            }

            Console.WriteLine(lastNameWithSpaces.Trim());
        }
    }
}
