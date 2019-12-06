using System;
namespace Sample_Phonebook{
class MenuList{
    public void Menu(){
        PhoneBook phonebook = new PhoneBook();
        Console.WriteLine("enter your choice");   
        int choice=Convert.ToInt32(Console.ReadLine());
        while(choice!=3){   
        switch(choice)
          {
             case 1:
                  phonebook.AddContact();
                  break;
             case 2:
                  phonebook.DisplayContact();
                  break;
             case 3:
                  System.Environment.Exit(0);
                  break;
             default:
                  Console.WriteLine("Enter the correct choice");
                  break;
          }
          Menu();
          }     
    }
}
}

