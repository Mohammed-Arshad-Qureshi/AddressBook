using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new AddressBook();

            bool userInput = true;

            while (userInput)
            {
                Console.WriteLine("See to Address Book Contacts      ----- press 1");
                Console.WriteLine("To Add Contact in Address Book    ----- press 2");
                Console.WriteLine("To Edit Existing Contact          ----- press 3");



                Console.WriteLine("Edit existing Contact Address Book ---- press X\n");
                Console.Write("######    Select any option above  #######   --:  ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        addressbook.Contacts();
                        break;
                    case "2":
                        addressbook.AddContact();
                        break;
                    case "3":
                        Console.Write("Enter the fist name to fetch the record :  ");
                        string first = Console.ReadLine();
                        addressbook.Edit(first);
                        break;
                   
                    case "X":
                        userInput = false;
                        break;
                    case "x":
                        userInput = false;
                        break;
                }
            }



        }
    }
}
