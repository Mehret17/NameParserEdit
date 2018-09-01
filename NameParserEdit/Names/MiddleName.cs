using System;

namespace NameParserEdit.Names
{
    class MiddleName : NameBase
    {
        private readonly FirstName _firstName;

        //construtor
        public MiddleName(FirstName firstName) : base("middle")
        {
            Name = "";
            _firstName = firstName;
        }


        public override void GetName()
        {

            if (userHasMiddleName())
            {
                base.GetName();
            }
            else
            {
                Console.WriteLine($@"{_firstName.Name}, that's fine.");
            }
        }

        bool userHasMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }


        public  override void PrintName()

        {
            var i = 0;
            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }

    }
}
