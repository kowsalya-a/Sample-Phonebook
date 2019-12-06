using System; 
namespace Sample_Phonebook
{
    class ConsoleHandler{
        public Contact GetContactDetails(Contact contact)
        {
            Console.WriteLine("Enter the name");
            contact.contactName = Console.ReadLine(); 
            Console.WriteLine("Enter the no ");
            contact.contactNumber = Console.ReadLine();
            Console.WriteLine("enter the emailid");
            contact.emailId = Console.ReadLine();
            return contact;
        }
        public void DisplayContactDetails(Contact contact)
        {  
             Console.WriteLine("Name:"+contact.contactName+"MobNo:"+contact.contactNumber+"EmailId:"+contact.contactNumber);
        }
    } 
} 

