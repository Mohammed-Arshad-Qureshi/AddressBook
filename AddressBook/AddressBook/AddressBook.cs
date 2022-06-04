using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {

        //Dictionary<string, Contact> data = new Dictionary<string, Contact>()
        // {
        //     {"111", new Contact{First = "Arshad" , Last="Mahammed",Address="x-y-z colony",City="vizag",State="AP",Zip="635002",phone="5468898858"} },
        //     {"122", new Contact{First = "salman", Last="khan",Address="aadd/d colony",City="vizag",State="MP",Zip="879875",phone="8759658548"} },
        //     {"133", new Contact{First = "Ravi", Last="kumar",Address="badd/d colony",City="Rjy",State="MP",Zip="879875",phone="8759654548"} },
        //     {"144", new Contact{First = "krishna", Last="sri",Address="caadd/d colony",City="vzm",State="Assam",Zip="279875",phone="8559658548"} }

        // };
        List<Contact> addressBook = new List<Contact>()
        {
             new Contact{First = "salman", Last="khan",Address="aadd/d colony",City="vizag",State="MP",Zip="879875",phone="8759658548"},
             new Contact{First = "Ravi", Last="kumar",Address="badd/d colony",City="Rjy",State="MP",Zip="879875",phone="8759654548"},
             new Contact{First = "krishna", Last="sri",Address="caadd/d colony",City="vzm",State="Assam",Zip="279875",phone="8559658548"},
             new Contact{First = "Arshad" , Last="Mahammed",Address="x-y-z colony",City="vizag",State="AP",Zip="635002",phone="5468898858"}

        };
        Dictionary<string, List<Contact>> addressBooks = new Dictionary<string, List<Contact>>();
        

        #region Display Contacts
        public void DisplayContacts()
        {
            Console.WriteLine("\n********  Contacts in Address Book  **********\n\n");

            foreach (var details in addressBook)
            {
                //Console.WriteLine("     Unique ID     :  " + details);
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
            //List<string> Keys = new List<string>(data.Keys);

            Console.WriteLine(" ********  Add Contact in Address Book  **********\n\n");
            //Console.Write("     Create Unique number to Address book    :  ");
            Contact con = new Contact();
            //string uniq = Console.ReadLine();
            //var value = data.FirstOrDefault(x => x.Key == uniq);

            Console.Write("     First Name    :  ");
            con.First = Console.ReadLine();
            //var name = data.FirstOrDefault(x => x.Value.First == con.First);
            foreach (var contact in addressBook)
            {

                if (contact.First.ToUpper() == con.First.ToUpper())
                {
                    Console.WriteLine("\n\n######### Contact already Present with that name #########\n");
                    return;
                }
                
            }
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
            addressBook.Add(con);




        }
        #endregion


        #region Edit Contact
        public void EditContact(string first)
        {
            var val = addressBook.FirstOrDefault(x => x.First == first);
            if (val != null)
            {
                foreach (Contact str in addressBook)
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
            foreach (var item in addressBook)
            {
                if (item.First == del)
                {
                    addressBook.Remove(item);
                    Console.WriteLine("\n******** Deleted Successfully  **********\n\n");

                }
                else
                {
                    Console.WriteLine("\n !!  Enterd data does not match with existing Record !! \n");
                }
            }

        }

        #endregion



        #region Search Contact
        public void SearchContact(string del)
        {
            int count = 0;
            //List<Contact> dict = data.Values.ToList();

            var dictt = addressBook.Where(x => x.City == del).ToList();
            foreach (var details in dictt)
            {
                if (details.City == del)
                {
                    count++;
                }

            }

            if (count > 0)
            {
                Console.WriteLine("\n #### The number of Contacts related to the city is : " + count + " #####\n\n");
                return;
            }
            else
            {
                Console.WriteLine("\n !!  Enterd data does not match with existing Record !! \n");
            }
        }

        public void Sorting()
        {
            addressBooks.Add("111",addressBook);

            //Console.WriteLine("After soring by Name");
            //foreach (var details in addressBook.OrderBy(x => x.Name))
            //{
            //    Console.WriteLine("     First Name    :  " + details.First);
            //    Console.WriteLine("     Last Name     :  " + details.Last);
            //    Console.WriteLine("     Address       :  " + details.Address);
            //    Console.WriteLine("     City          :  " + details.City);
            //    Console.WriteLine("     State         :  " + details.State);
            //    Console.WriteLine("     Zip           :  " + details.Zip);
            //    Console.WriteLine("     Phone Number  :  " + details.phone);
            //    Console.WriteLine("\n\n");
            //}

            Console.WriteLine("After soring by City");
            foreach (var details in addressBook.OrderBy(x => x.City))
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

        }

        public void WriteContactsInFile()
        {
            string path = @"E:\Visual_Studio\AddressBook\AddressBook\AddressBook\AddressBookFile.txt";
            if(File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                   foreach(var details in addressBook)
                    {
                        sw.WriteLine("     First Name    :  " + details.First);
                        sw.WriteLine("     Last Name     :  " + details.Last);
                        sw.WriteLine("     Address       :  " + details.Address);
                        sw.WriteLine("     City          :  " + details.City);
                        sw.WriteLine("     State         :  " + details.State);
                        sw.WriteLine("     Zip           :  " + details.Zip);
                        sw.WriteLine("     Phone Number  :  " + details.phone);
                        sw.WriteLine("\n\n");
                    }

                }

            }
            else
            {
                Console.WriteLine("!Page Not Found");
            }

        }

        public void ReadDataFromFile()
        {
            string path = @"E:\Visual_Studio\AddressBook\AddressBook\AddressBook\AddressBookFile.txt";

            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();
            
            //using(StreamReader sr = new StreamReader(path))
            //{
            //    string str = string.Empty;

            //    while ((str == sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(str);
            //    }
            //}
            //Console.ReadKey();

        }

        #endregion
    }

}
