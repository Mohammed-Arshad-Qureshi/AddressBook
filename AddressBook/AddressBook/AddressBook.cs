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
             {"122", new Contact{First = "salman", Last="khan",Address="aadd/d colony",City="vizag",State="MP",Zip="879875",phone="8759658548"} },
             {"133", new Contact{First = "Ravi", Last="kumar",Address="badd/d colony",City="Rjy",State="MP",Zip="879875",phone="8759654548"} },
             {"144", new Contact{First = "krishna", Last="sri",Address="caadd/d colony",City="vzm",State="Assam",Zip="279875",phone="8559658548"} }

         };



        #region Display Contacts
        public void DisplayContacts()
        {
            Console.WriteLine("\n********  Contacts in Address Book  **********\n\n");
            
            foreach (var details in data) 
            {
                Console.WriteLine("     Unique ID     :  " + details.Key);
                Console.WriteLine("     First Name    :  " + details.Value.First);
                Console.WriteLine("     Last Name     :  " + details.Value.Last);
                Console.WriteLine("     Address       :  " + details.Value.Address);
                Console.WriteLine("     City          :  " + details.Value.City);
                Console.WriteLine("     State         :  " + details.Value.State);
                Console.WriteLine("     Zip           :  " + details.Value.Zip);
                Console.WriteLine("     Phone Number  :  " + details.Value.phone);
                Console.WriteLine("\n\n");

            }
            Console.WriteLine(" ***********************************************\n\n");

        }
        #endregion


        #region Add Contact
        public void AddContact()
        {
            List<string> Keys = new List<string>(data.Keys);
            Console.WriteLine(" ********  Add Contact in Address Book  **********\n\n");
            Console.Write("     Create Unique number to Address book    :  ");
            Contact con = new Contact();
            string uniq = Console.ReadLine();
            var value = data.FirstOrDefault(x => x.Key == uniq);
            if(value.Key != uniq)
            {
                Console.Write("     First Name    :  ");
                con.First = Console.ReadLine();
                var name = data.FirstOrDefault(x => x.Value.First == con.First);
                if(name.Key == null)
                {
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
                    data.Add(uniq, con);
                    DisplayContacts();
                   
                   
                }
                else
                {
                    Console.WriteLine("\n\n######### Contact already Present with that name #########\n");
                    return;
                }
               
            }
            else
            {
                Console.WriteLine("\n\n ############ ID already present it must be unique ##########\n\n");
                return;
            }

           

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



        #region Search Contact
        public void SearchContact(string del)
        {
            bool flag = false;
            //var dict = data.Select(x => x.Value.City == del).ToList();
            foreach(var details in data)
            {
                if (details.Value.City == del)
                {
                        Console.WriteLine("     Unique ID     :  " + details.Key);
                        Console.WriteLine("     First Name    :  " + details.Value.First);
                        Console.WriteLine("     Last Name     :  " + details.Value.Last);
                        Console.WriteLine("     Address       :  " + details.Value.Address);
                        Console.WriteLine("     City          :  " + details.Value.City);
                        Console.WriteLine("     State         :  " + details.Value.State);
                        Console.WriteLine("     Zip           :  " + details.Value.Zip);
                        Console.WriteLine("     Phone Number  :  " + details.Value.phone);
                        Console.WriteLine("\n\n");
                    flag = true;
                }
            }
            if(flag == true)
            {
                return;
            }
            else
            {
                Console.WriteLine("\n !!  Enterd data does not match with existing Record !! \n");
            }
        }

        #endregion
    }

}
