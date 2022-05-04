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
            string active = "";
            string iden = "";
            string ret = "";
            bool returningCheck = false;
            Console.WriteLine("Welcome to blabbr vers. 1.0");
            Console.WriteLine("Are you a returning user (R) or a new user (N)");
            Console.WriteLine("Please write your answer below, then press enter");
            char userState = Convert.ToChar(Console.ReadLine());
            string newUserName = "";
            string newPassWord = "";
            string userName = "";
            string passWord = "";

            if (userState == 'N')
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

            if (userState == 'R')
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

            if (userState == 'N')
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

            if (userState == 'N') {
            if (active == iden)
            {
                Console.WriteLine("");
                Console.WriteLine("You have successfully authenticated an account with Blabbr!");
                Console.WriteLine("");
                Console.WriteLine("Username: " + newUserName);
                Console.WriteLine("Password: " + newPassWord);
            }
            }
            
            if (userState == 'R')
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
            



                Console.ReadLine();

            }
        }
    }


