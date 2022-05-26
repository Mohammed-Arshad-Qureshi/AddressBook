using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        List<Contact> data = new List<Contact>
            {
                new Contact{First = "Arshad" , Last="Mahammed",Address="x-y-z colony",City="vizag",State="AP",Zip="635002",phone="5468898858"},
                new Contact{First = "salman", Last="khan",Address="aadd/d colony",City="vishakapatnam",State="MP",Zip="879875",phone="8759658548"},
                new Contact{First = "Ravi", Last="kumar",Address="badd/d colony",City="Rjy",State="MP",Zip="879875",phone="8759654548"},
                new Contact{First = "krishna", Last="sri",Address="caadd/d colony",City="vzm",State="Assam",Zip="279875",phone="8559658548"}

            };

        public void DisplayContacts()
        {
            Console.WriteLine("\n********  Contacts in Address Book  **********\n\n");
            foreach (Contact details in data)
            {
                Console.WriteLine("     First Name    :  " + details.First);
                Console.WriteLine("     Last Name     :  " + details.Last);
                Console.WriteLine("     Address       :  " + details.Address);
                Console.WriteLine("     City          :  " + details.City);
                Console.WriteLine("     State         :  " + details.State);
                Console.WriteLine("     Zip           :  " + details.Zip);
                Console.WriteLine("     Phone Number  :  " + details.phone);
                Console.WriteLine("\n\n");

            }
            Console.WriteLine(" ***********************************************\n\n");

        }

        public void AddContact()
        {
            Console.WriteLine(" ********  Add Contact in Address Book  **********\n\n");

            Contact con = new Contact();
            Console.Write("     First Name    :  ");
            con.First = Console.ReadLine();
            Console.Write("     Last Name     :  ");
            con.Last = Console.ReadLine();
            Console.Write("     Address       :  ");
            con.Address = Console.ReadLine();
            Console.Write("     City          :  ");
            con.City = Console.ReadLine();
            Console.Write("     State         :  ");
            con.State = Console.ReadLine();
            Console.Write("     Zip           :  ");
            con.Zip = Console.ReadLine();
            Console.Write("     Phone Number  :  ");
            con.phone = Console.ReadLine();
            data.Add(con);
            DisplayContacts();


        }
    }

}
