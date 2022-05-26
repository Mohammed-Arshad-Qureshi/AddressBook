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
            addressbook.DisplayContacts();
            addressbook.AddContact();
            Console.Write("Enter first name to Edit Record :  ");
            string first = Console.ReadLine();
            addressbook.EditContact(first);
            Console.Write("Enter first name to Delete Record :  ");
            string del = Console.ReadLine();
            addressbook.DeleteContact(del);
            Console.ReadLine();


        }
    }
}
