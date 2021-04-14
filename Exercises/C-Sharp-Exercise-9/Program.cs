using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace C_Sharp_Exercise_9
{
    class Program
    {
     
        // Must ensure username is unique.
        // Recieve plain text password -> Hash and store password
        // Must print Properly/Not Properly Authenticated.

        // Must use generic Dictionary.
        // User must always be returned to initial interface.


        static Dictionary<string, string> userAccounts = new Dictionary<string, string>();


        static void Main(string[] args)
        {

            int selection = printUI();
        

            if (selection == 1)
            {
                getNewUser();
                
            }
            else if (selection == 2)
            {
                getUser();
                
            }
            else if (selection == 3) 
            {
                printUsers();
                
            }
            else if (selection == 4)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Sorry, please select one of the available choices.");
                
            }
        }

        private static void getNewUser()
        {
            Console.WriteLine("Please enter a username.");
            string username = Console.ReadLine();            
            Console.WriteLine("Please enter a password.");
            string password = Console.ReadLine();           
            userAccounts.Add(username, ComputeMD5hash(password));
            Console.WriteLine($"New account successfully created for {username}!");
            Console.ReadLine();
            printUI();
        }

        private static void getUser()
        {
            Console.WriteLine("Please enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            string tempHash = ComputeMD5hash(password);
            KeyValuePair<string, string> keyValuePair = <username, tempHash>; 
        

            if (userAccounts.ContainsKey(username) == true)
            {
                if (ValidateMD5Hash(password) == true)                               // userAccounts.TryGetValue(username, ComputeMD5hash(password) == true)
                {

                    Console.WriteLine("You have been properly authenticated.");
                }
                else
                {

                    Console.WriteLine("Could not authenticate. Please enter correct password.");
                }
            }

            else
                Console.WriteLine("Username not found. Please enter a valid username.");
        }

        private static void printUsers()
        {
            Console.WriteLine("This is the list of currently registered users: ");

            foreach (KeyValuePair<string, string> element in userAccounts) // Doesn't work. Not sure why.
            {
                string username = element.Key;
                string password = element.Value;
                Console.WriteLine($"Name:{username}, Password:{password}");
                Console.ReadLine();
                printUI();
            }
        }

        private static int printUI()
        {
            Console.WriteLine("Welcome! Please select an option:\n");
            Console.WriteLine("1. Establish new user account.");
            Console.WriteLine("2. Authenticate user account.");
            Console.WriteLine("3. List current accounts.");
            Console.WriteLine("4. Exit\n");
            Console.WriteLine("Enter Selection: ");
            string number = Console.ReadLine();
            int selection = int.Parse(number);
            return selection;
        }

        private static string ComputeMD5hash(string password)
        {
            StringBuilder stringBuilder = new StringBuilder();
            byte[] textBytes = Encoding.ASCII.GetBytes(password);
            using (MD5 md5 = MD5.Create())
            {
                byte[] computeHash = md5.ComputeHash(textBytes);
                for (int i = 0; i < computeHash.Length; i++)
                {
                    stringBuilder.Append(computeHash[i].ToString("?"));
                }
            }
            return stringBuilder.ToString();
        }

        private static bool ValidateMD5Hash(string username, string password)
        {
            string tempHash = ComputeMD5hash(password);
            bool flag;
            if (string.Compare(tempHash, userAccounts) == 0)            
                flag = true;
            else           
                flag = false;
            return flag;
        }

    }
}
