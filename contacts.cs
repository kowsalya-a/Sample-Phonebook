using System;
using System.Collections; 
using System.Collections.Generic; 
using Sample_Phonebook;

namespace Contacts
{
       class Contact
       {
            public void AddContact(List<string> Contactname,List<int> Contactnumber){
            Console.WriteLine("Enter the contact name");
            Console.Write("Name:");
            Contactname.Add(Console.ReadLine());
            Console.WriteLine("Enter the number");
            Console.Write("Number:");
            Contactnumber.Add(int.Parse(Console.ReadLine()));
        }
        
            public  void DeleteContact(List<string> Contactname,List<int> Contactnumber){
            Console.WriteLine("Enter the name that u want to delete");
            string name=Console.ReadLine();
            Contactname.Remove(name);
            Console.WriteLine("enter the number that u want to delete");
            int number=int.Parse(Console.ReadLine());
            Contactnumber.Remove(number);
        } 
            public void SearchContact(List<string> Contactname,List<int> Contactnumber){
            Console.WriteLine("Enter the name that u want to search");
            string searchname=Console.ReadLine();
            Contactname.Contains(searchname);
            Console.WriteLine("Enter the number that u want to search");
            int searchnumber=int.Parse(Console.ReadLine());
            Contactnumber.Contains(searchnumber);

        }
       }
}