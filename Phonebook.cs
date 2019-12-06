using System.Collections.Generic;

namespace Sample_Phonebook
{
    public class PhoneBook{
        List<Contact> contacts = new List<Contact>();
        Contact contact = new Contact(); 
        ConsoleHandler consoleHandler = new ConsoleHandler();
        WriteToFile writeToFile = new WriteToFile();
        public void AddContact()
        {
            consoleHandler.GetContactDetails(contact);
            contacts.Add(contact); 
            writeToFile.FileHandler(contacts); 

        }  
        public void DisplayContact()
        {
             consoleHandler.DisplayContactDetails(contact);
             
        }
          
    }
}
