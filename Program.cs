using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    public class ValidException : Exception
    {
        public ValidException(string message): base(message) 
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                
                try
                {
                    string userName, email, password;
                    Console.WriteLine("Enter the user name: ");
                    userName = Console.ReadLine();
                    Console.WriteLine("Enter the email: ");
                    email = Console.ReadLine();
                    Console.WriteLine("Enter the password");
                    password = Console.ReadLine();

                    int minLength = 6;
                    
                    int passwordLength = 8;
                    
                    if (minLength > userName.Length)  //Only executes if the user enter less than 6 (ex. 6 > 5)
                    {
                        throw new ValidException("The user name atleast have 6 characters");
                    }
                    else if (passwordLength > password.Length)   //Only Executes if the user enter less than 8 characters (ex. 8 > 7)
                    {
                        throw new ValidException("Password atleast have 8 characters");
                    }
                    else  //If user enters the correct length for both user name and password then this will execute
                    {
                        Console.WriteLine("Logged in Successfully\n");
                        Console.WriteLine("User Name: " + userName);
                        Console.WriteLine("Email: " + email);
                        Console.WriteLine("Password: " + password);
                    }
                }
                catch (ValidException ve)
                {
                    Console.WriteLine("Validation Error Occured!!! " + ve.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error!!!" + ex.Message);
                }
                finally
                {
                    Console.WriteLine("\nProgram Ended");
                    Console.WriteLine($"\nDo you wish to conitnue if yes press 'y' or press any other key");
                    choice = char.Parse(Console.ReadLine());
                    Console.ReadKey();
                }
                
            } while (choice == 'y');
            

            

        }
    }
}
