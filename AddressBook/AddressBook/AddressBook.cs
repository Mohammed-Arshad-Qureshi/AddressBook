using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {

        Dictionary<string, Contact> data = new Dictionary<string, Contact>()
         {
             {"111", new Contact{First = "Arshad" , Last="Mahammed",Address="x-y-z colony",City="vizag",State="AP",Zip="635002",phone="5468898858"} },
             {"122", new Contact{First = "salman", Last="khan",Address="aadd/d colony",City="vishakapatnam",State="MP",Zip="879875",phone="8759658548"} },
             {"133", new Contact{First = "Ravi", Last="kumar",Address="badd/d colony",City="Rjy",State="MP",Zip="879875",phone="8759654548"} },
             {"144", new Contact{First = "krishna", Last="sri",Address="caadd/d colony",City="vzm",State="Assam",Zip="279875",phone="8559658548"} }

         };


        #region Display Contacts
        public void DisplayContacts()
        {
            Console.WriteLine("\n********  Contacts in Address Book  **********\n\n");
            foreach (Contact details in data.Values)
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
        #endregion


        #region Add Contact
        public void AddContact()
        {
            Console.WriteLine(" ********  Add Contact in Address Book  **********\n\n");
            Console.Write("     Create Unique number to Address book    :  ");
            Contact con = new Contact();
            string uniq = Console.ReadLine();
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
            data.Add(uniq,con);
            DisplayContacts();

        }
        #endregion


        #region Edit Contact
        public void EditContact(string first)
        {
            var val = data.FirstOrDefault(x => x.Value.First == first);
            if (val.Value != null)
            {
                foreach (Contact str in data.Values)
                {
                    if (str.First == first)
                    {
                        Console.WriteLine("\n\n ********  Edit Contact in Address Book  **********\n\n");
                        Console.Write("     First Name    :  ");
                        str.First = Console.ReadLine();
                        Console.Write("     Last Name     :  ");
                        str.Last = Console.ReadLine();
                        Console.Write("     Address       :  ");
                        str.Address = Console.ReadLine();
                        Console.Write("     City          :  ");
                        str.City = Console.ReadLine();
                        Console.Write("     State         :  ");
                        str.State = Console.ReadLine();
                        Console.Write("     Zip           :  ");
                        str.Zip = Console.ReadLine();
                        Console.Write("     Phone Number  :  ");
                        str.phone = Console.ReadLine();

                    }

                }
                Console.WriteLine("\n******** After Editing Contact in Address Book  **********\n\n");
                DisplayContacts();
            }
            else
            {
                Console.WriteLine("\n\n ! Entered Data  does not match with existing Contact");
            }
        }
        #endregion

        #region Delete Contact
        public void DeleteContact(string del)
        {
            var val = data.FirstOrDefault(x => x.Value.First == del);
            if (val.Value!= null)
            {
                data.Remove(val.Key);

                Console.WriteLine("\n******** After Deleting Contact in Address Book  **********\n\n");
                DisplayContacts();
            }
            else
            {
                Console.WriteLine("\n !!  Enterd data does not match with existing Record !! \n");
            }
        }

        #endregion
    }

}
