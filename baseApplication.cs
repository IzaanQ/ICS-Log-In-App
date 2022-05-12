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
            userState = char.ToLower(userState); //makes user input into a lowercase char to guarantee results regardless of negligence
            string newUserName = ""; //initialise new user username string (false for the time being)
            string newPassWord = ""; //initialise new user password string (false for the time being)
            string userName = ""; //initialise existing user username
            string passWord = ""; //initialise existing user password

            if (userState == 'n') //if the current user is a new user, do the following code in the block
            {
                Console.WriteLine(""); //styling
                Console.WriteLine("Welcome to Blabbr! Please create a username, then press enter!"); //welcome message - instruction to make username
                newUserName = Convert.ToString(Console.ReadLine()); //update new username to user input
                Console.WriteLine(""); //styling
                Console.WriteLine("Please create a password, then press enter."); //instruction to make password
                ConsoleColor origBG = Console.BackgroundColor; //store original background colour value
                ConsoleColor origFG = Console.ForegroundColor; //store original foreground colour value
                Console.BackgroundColor = ConsoleColor.White; //set the block colour
                Console.ForegroundColor = ConsoleColor.White; //set the foreground colour (This is all to hide the password from snoopers)
                newPassWord = Convert.ToString(Console.ReadLine()); //update new password to user input
                Console.BackgroundColor = origBG; //revert background colour to original
                Console.ForegroundColor = origFG; //revert foreground colour to original
                iden = (newUserName + newPassWord); //define identity value

            }

            if (userState == 'r') //if the current user is a returning user, do the following code block
            {
                Console.WriteLine(""); //styling
                Console.WriteLine("Please enter your username below, then press enter"); //prompt for user to input existing username
                userName = Convert.ToString(Console.ReadLine()); // update running username as user input
                Console.WriteLine(""); //styling
                Console.WriteLine("Please enter your password, then press enter."); //prompt for user to input existing username
                ConsoleColor origBG = Console.BackgroundColor; //store original background colour value
                ConsoleColor origFG = Console.ForegroundColor; //store original foreground colour value
                Console.BackgroundColor = ConsoleColor.White; // set the block colour
                Console.ForegroundColor = ConsoleColor.White; //set the foreground colour (This is all to hide the password from snoopers)
                passWord = Convert.ToString(Console.ReadLine()); //update running password as user input
                Console.BackgroundColor = origBG; //revert background colour to original
                Console.ForegroundColor = origFG; //revert foreground colour to origninal
                ret = (userName + passWord); //define returning value 
            }

            TextWriter tw = new StreamWriter("C:/text/text.txt", true); //initialise text document and writer use

            if (userState == 'n') //if the current user is a new user, do the following code in the block
            {
                tw.WriteLine(newUserName + newPassWord); //text wrtite (write on the document) user identity values
            }

            tw.Close(); //conclude text writer use


            char[] array = new char[0]; //initialise blank/empty char array
            int counter = 0; //initialise counter at 0
            foreach (string line in System.IO.File.ReadLines(@"C:/text/text.txt")) //for every line in text.txt
            {
                counter++; //add 1 to the running counter
                active = (line); //deifne active as the line reading
            }

            if (userState == 'n') //if the current user is a new user, do the following code in the block
            {
            if (active == iden) //if the active identity is the same as the real identity, do the following code block
            {
                Console.WriteLine(""); //styling
                Console.WriteLine("You have successfully authenticated an account with Blabbr!"); //Success statement
                Console.WriteLine(""); //styling
                Console.WriteLine("Username: " + newUserName); //inform user of the password
                ConsoleColor origBG = Console.BackgroundColor; //store original background colour value
                Console.WriteLine("Password: "); //user password indicator
                ConsoleColor origFG = Console.ForegroundColor; //store original bforeground colour value
                Console.BackgroundColor = ConsoleColor.White; //set the block colour
                Console.ForegroundColor = ConsoleColor.White; //set the foreground colour (This is all to hide the password from snoopers)
                Console.WriteLine(newPassWord); //print actual user password (but it is hidden)
                Console.BackgroundColor = origBG; //revert background colour to original
                Console.ForegroundColor = origFG; //revert foreground colour to original
            }
            }
            
            if (userState == 'r') //if the user is a returning user, run the following code block
            {
                int altcounter = 0; //initialise alternate counter at 0
                foreach (string line in System.IO.File.ReadLines(@"C:/text/text.txt")) //for every line in the text document, do the following
                {
                    altcounter++; //add one to the running alternate counter
                    if (ret == line) //if the returning value is equal to the active value, run the following code block
                    {
                        returningCheck = true; //set boolean check value to be true
                    }
                }

                if (returningCheck == true) //if the boolean value is true, run the following code block
                {
                    Console.WriteLine(""); //styling
                    Console.WriteLine("You have successfully logged in to blabbr!"); //success message
                }
                else
                {
                    Console.WriteLine(""); //styling
                    Console.WriteLine("Unfortunately, we could not retrieve your account."); //error message
                }

            }

            if (userState == 'n') //if the user is a new user, run the following code block
            {
                Console.WriteLine(""); //styling
                Console.WriteLine("Type 'password', and press enter, if you would like to see your password"); //user prompt giving instruction to see set password
                Console.WriteLine(""); //styling
                string userAnswer = Convert.ToString(Console.ReadLine()); //define the users answer as the user input
                if (userAnswer == "password") //if the users answer is 'password', run the followign code block
                {
                    Console.WriteLine(""); //styling
                    Console.WriteLine("Password: " + newPassWord); //output user password
                }
                else //if the set condition is not met, do the following code block
                {
                Console.WriteLine("error"); //error message prompt
                }

            }

            



                Console.ReadLine(); //run written codes

            }
        }
    }


