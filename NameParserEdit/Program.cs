using System;
using NameParserEdit.Names;

namespace NameParserEdit
{
    class Program
    {
        static void Main(string[] args)

        {

            var firstName = new FirstName(); // instiatiatioing
            var middleName = new MiddleName(firstName);
            var lastName = new LastName();

            var names = new NameBase[] { firstName, lastName, middleName }; // creating an array

            foreach(var name in names)
            {
                name.GetName();
                name.PrintName();
            }


            Console.WriteLine($"Goodbye {firstName.Name} {middleName.Name} {lastName.Name}. Press enter to exit.");
            Console.ReadLine();
        }
    }
}
