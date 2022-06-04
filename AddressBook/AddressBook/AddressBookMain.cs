using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new AddressBook();

            bool userInput = true;

            while (userInput)
            {
                Console.WriteLine("To SEE Contacts in  AddressBook   ----- press 1");
                Console.WriteLine("To ADD Contact in Address Book    ----- press 2");
                Console.WriteLine("To Edit Existing Contact          ----- press 3");
                Console.WriteLine("To DELETE Existing Contact        ----- press 4");
                Console.WriteLine("To Search Existing Contact        ----- press 5");
                Console.WriteLine("To sort by First Name             ----- press 6");


                Console.WriteLine("To EXIT                           ----- press x");


                Console.Write("\n######    Select any option above  #######   --:  ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        addressbook.DisplayContacts();
                        break;
                    case "2":
                        addressbook.AddContact();
                        break;
                    case "3":
                        Console.Write("Enter the fist name to fetch the record :  ");
                        string first = Console.ReadLine();
                        addressbook.EditContact(first);
                        break;
                    case "4":
                        Console.Write("Enter the fist name to fetch the record :  ");
                        string del = Console.ReadLine();
                        addressbook.DeleteContact(del);
                        break;
                    case "5":
                        Console.Write("Enter the City name to fetch the record :  ");
                        string cityData = Console.ReadLine();
                        addressbook.SearchContact(cityData);
                        break;
                    case "6":
                        Console.WriteLine("#### Sort Contacts by FirstName ####\n");
                        addressbook.Sorting();
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
