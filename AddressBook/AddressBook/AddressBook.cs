using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        Contact con = new Contact();
        public void contacts()
        {
            List<Contact> data = new List<Contact>
            {
                new Contact{First = "Arshad" , Last="Mahammed",Address="x-y-z colony",City="vizag",State="AP",Zip="635002",phone="5468898858"},
                new Contact{First = "salman", Last="khan",Address="aadd/d colony",City="vishakapatnam",State="MP",Zip="879875",phone="8759658548"},
                new Contact{First = "Ravi", Last="kumar",Address="badd/d colony",City="Rjy",State="MP",Zip="879875",phone="8759654548"},
                new Contact{First = "krishna", Last="sri",Address="caadd/d colony",City="vzm",State="Assam",Zip="279875",phone="8559658548"}

            };
            Console.WriteLine("Contacts Present\n\n");
            foreach (Contact c in data)
            {
                Console.WriteLine("****************************\n");

                Console.WriteLine(c.First);
                Console.WriteLine(c.Last);
                Console.WriteLine(c.Address);
                Console.WriteLine(c.City);
                Console.WriteLine(c.State);
                Console.WriteLine(c.Zip);
                Console.WriteLine(c.phone);

                Console.WriteLine("****************************\n");
            }
        }


    }
}
