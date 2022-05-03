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
                newPassWord = Convert.ToString(Console.ReadLine());
                iden = (newUserName + newPassWord);
            }

            if (userState == 'R')
            {
                Console.WriteLine("Please enter your username below, then press enter");
                userName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Please enter your password below, then press enter");
                passWord = Convert.ToString(Console.ReadLine());
                ret = (userName + passWord);
            }

            TextWriter tw = new StreamWriter("C:/text/text.txt", true);

            if (userState == 'N')
            {
                tw.WriteLine(newUserName + newPassWord);
                tw.Close();
            }

            if (userState == 'R')
            {
                tw.WriteLine("");
                tw.Close();
            }


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
                        Console.WriteLine("");
                        Console.WriteLine("Welcome back to blabbr!");
                    }
                }
            }


                Console.ReadLine();

            }
        }
    }


