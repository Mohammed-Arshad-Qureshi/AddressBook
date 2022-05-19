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
        List<Contact> data = new List<Contact>
            {
                new Contact{First = "Arshad" , Last="Mahammed",Address="x-y-z colony",City="vizag",State="AP",Zip="635002",phone="5468898858"},
                new Contact{First = "salman", Last="khan",Address="aadd/d colony",City="vishakapatnam",State="MP",Zip="879875",phone="8759658548"},
                new Contact{First = "Ravi", Last="kumar",Address="badd/d colony",City="Rjy",State="MP",Zip="879875",phone="8759654548"},
                new Contact{First = "krishna", Last="sri",Address="caadd/d colony",City="vzm",State="Assam",Zip="279875",phone="8559658548"}

            };
        public void Contacts()
        {
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


        //ADD contacts

        public void AddContact()
        {
            Console.WriteLine("\n###########  Add Contact in Address Book ##################\n");
            Console.Write("Enter First Name:  ");
            con.First = Console.ReadLine();
            Console.Write("Enter Last Name:  ");
            con.Last = Console.ReadLine();
            Console.Write("Enter Address:  ");
            con.Address = Console.ReadLine();
            Console.Write("Enter City:  ");
            con.City = Console.ReadLine();
            Console.Write("Enter State:  ");
            con.State = Console.ReadLine();
            Console.Write("Enter ZipCode:  ");
            con.Zip = Console.ReadLine();
            Console.Write("Enter Phone Number:  ");
            con.phone = Console.ReadLine();

            data.Add(con);

            Console.WriteLine("------ After Adding Contact in Address Book ---------\n");
            Contacts();
        }

       


        //Edit Contact

        public void Edit(string first)
        {

            var val = data.FirstOrDefault(x => x.First == first);
            if (val != null)
            {
                foreach (Contact str in data)
                {
                    if (str.First == first)
                    {
                        Console.Write("Enter First Name:  ");
                        str.First = Console.ReadLine();
                        Console.Write("Enter Last Name:  ");
                        str.Last = Console.ReadLine();
                        Console.Write("Enter Address:  ");
                        str.Address = Console.ReadLine();
                        Console.Write("Enter City:  ");
                        str.City = Console.ReadLine();
                        Console.Write("Enter State:  ");
                        str.State = Console.ReadLine();
                        Console.Write("Enter ZipCode:  ");
                        str.Zip = Console.ReadLine();
                        Console.Write("Enter Phone Number:  ");
                        str.phone = Console.ReadLine();

                    }

                }
                Console.WriteLine("---------- After Editing -----------");

                Contacts();
            }
            else
            {
                Console.WriteLine("\n !!  Enterd data does not match with existing Record !! \n");
            }


        }
    }

}
