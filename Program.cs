
namespace Sample_Phonebook
{
    class Program 
    {
        static void Main(string[] args)
        { 
          ConsoleHandler consoleHandler = new ConsoleHandler();
          PhoneBook phoneBook = new PhoneBook();
          MenuList menuList = new MenuList();
          menuList.Menu(); 
        }  
    }
}


            