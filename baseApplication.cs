using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string active = ""; //intialise active string (empty for the time being)
            string iden = ""; //intialise identity string (empty for the time being)
            string ret = ""; // initialise return string (empty for the time being)
            bool returningCheck = false; //default setting of returning check (false for the time being)
            Console.WriteLine("Welcome to blabbr vers. 1.0"); //Welcome user to the application
            Console.WriteLine("Are you a returning user (R) or a new user (N)"); //Ask the user if they are a new or returning
            Console.WriteLine("Please write your answer below, then press enter"); // Ask the user to input their answer and press enter
            char userState = Convert.ToChar(Console.ReadLine()); //declare the users state as the users answer (R) or (N)
            userState = char.ToLower(userState);
            string newUserName = ""; //initialise new user username string (false for the time being)
            string newPassWord = ""; //initialise new user password string (false for the time being)
            string userName = ""; //initialise existing user username
            string passWord = ""; //initialise existing user password

            if (userState == 'n') //if the current user is a new user, do the following code in the block
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to Blabbr! Please create a username, then press enter!");
                newUserName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Please create a password, then press enter.");
                ConsoleColor origBG = Console.BackgroundColor; // Store original values
                ConsoleColor origFG = Console.ForegroundColor;
                Console.BackgroundColor = ConsoleColor.White; // Set the block colour (could be anything)
                Console.ForegroundColor = ConsoleColor.White;
                newPassWord = Convert.ToString(Console.ReadLine());
                Console.BackgroundColor = origBG; // revert back to original
                Console.ForegroundColor = origFG;
                iden = (newUserName + newPassWord);

            }

            if (userState == 'r')
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter your username below, then press enter");
                userName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Please enter your password, then press enter.");
                ConsoleColor origBG = Console.BackgroundColor; // Store original values
                ConsoleColor origFG = Console.ForegroundColor;
                Console.BackgroundColor = ConsoleColor.White; // Set the block colour (could be anything)
                Console.ForegroundColor = ConsoleColor.White;
                passWord = Convert.ToString(Console.ReadLine());
                Console.BackgroundColor = origBG; // revert back to original
                Console.ForegroundColor = origFG;
                ret = (userName + passWord);
            }

            TextWriter tw = new StreamWriter("C:/text/text.txt", true);

            if (userState == 'n')
            {
                tw.WriteLine(newUserName + newPassWord);
            }

            tw.Close();


            char[] array = new char[0];
            int counter = 0;
            foreach (string line in System.IO.File.ReadLines(@"C:/text/text.txt"))
            {
                counter++;
                active = (line);
            }

            if (userState == 'n') {
            if (active == iden)
            {
                Console.WriteLine("");
                Console.WriteLine("You have successfully authenticated an account with Blabbr!");
                Console.WriteLine("");
                Console.WriteLine("Username: " + newUserName);
                ConsoleColor origBG = Console.BackgroundColor; // Store original values
                Console.WriteLine("Password: ");
                ConsoleColor origFG = Console.ForegroundColor;
                Console.BackgroundColor = ConsoleColor.White; // Set the block colour (could be anything)
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pas: " + newPassWord);
                Console.BackgroundColor = origBG; // revert back to original
                Console.ForegroundColor = origFG;
            }
            }
            
            if (userState == 'r')
            {
                int altcounter = 0;
                foreach (string line in System.IO.File.ReadLines(@"C:/text/text.txt"))
                {
                    altcounter++;
                    if (ret == line)
                    {
                        returningCheck = true;
                    }
                }

                if (returningCheck == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully logged in to blabbr!");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Unfortunately, we could not retrieve your account.");
                }

            }

            if (userState == 'n')
            {
                Console.WriteLine("Type 'password', and press enter, if you would like to see your password");
                Console.WriteLine("");
                string userAnswer = Convert.ToString(Console.ReadLine());
                if (userAnswer == "password")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Password: " + newPassWord);
                }
                else {
                Console.WriteLine("error");
                }

            }

            



                Console.ReadLine();

            }
        }
    }


