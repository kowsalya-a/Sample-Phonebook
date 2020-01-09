using System;
using System.Collections.Generic;
using System.IO;

namespace Sample_Phonebook
{
    class WriteToFile{
        public void FileHandler(List<Contact> contacts )
        {
           //string data;
          // FileStream fileStream = new FileStream("D:\\Text.txt", FileMode.Open, FileAccess.Read);
         //  using (StreamReader streamReader = new StreamReader(fileStream))
        //   {
        //        data = streamReader.ReadToEnd();
         //  }
         //  Console.WriteLine(data);
         //  Console.ReadLine(); 

            string path = @"C:\Users\akowsalya\text.txt";
            
            using (var writeToFile = new StreamWriter(path, true))
            {
                foreach (var item in contacts)
                {
                    string messageToBePrinted = string.Concat("FirstName: ", item.contactName, Environment.NewLine,   "PhoneNumber: ", item.contactNumber, Environment.NewLine, "Email: ", item.emailId);
                    writeToFile.WriteLine(messageToBePrinted);
                    
                }
            }
        }
        
    }
}


