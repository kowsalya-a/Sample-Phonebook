using System;
using System.Collections; 
using System.Collections.Generic; 
using contacts;

namespace Sample_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {    

         List<string> Contactname=new List<string>();
         List<int> Contactnumber=new List<int>();
         contact contacts=new contact();
         Console.WriteLine("Enter your choice 1.Add 2.Delete 3.Search");
         int choice=Convert.ToInt32(Console.ReadLine());
         switch(choice)
         {
             case 1:
                  contacts.addContact(Contactname, Contactnumber);
                  break;
             
             case 2:
                  contacts.Deletecontact(Contactname, Contactnumber);
                  break;
             case 3:
                  contacts.Searchcontact(Contactname, Contactnumber);
                  break;
         }
        }
        
    }
    }


            