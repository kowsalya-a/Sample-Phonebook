using System;
using System.Collections.Generic; 

namespace Sample_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {    

         List<string> Contactname=new List<string>();
         List<int> Contactnumber=new List<int>();
         Console.WriteLine("Enter your choice 1.Add 2.Display 3.Delete");
         int choice=Convert.ToInt32(Console.ReadLine());
         switch(choice)
         {
             case 1:
                  Addcontact(Contactname, Contactnumber);
                  break;
             
             case 2:
                  Deletecontact(Contactname);
                  break;
         }
        }
        private static void Addcontact(List<string> Contactname ,List<int> Contactnumber){
            Console.WriteLine("Enter the contact name");
            Console.Write("Name:");
            Contactname.Add(Console.ReadLine());
            Console.WriteLine("Enter the number");
            Console.Write("Number:");
            Contactnumber.Add(int.Parse(Console.ReadLine()));
        }
        
        private static void Deletecontact(List<string> Contactname){
            Console.WriteLine("Enter the name that u want to delete");
            string name=Console.ReadLine();
            Contactname.Remove(name);
        } 
        }
    }


            