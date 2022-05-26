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
            Console.ReadLine();
        }
    }
}
