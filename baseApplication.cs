using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            }

            if (userState == 'R')
            {
                Console.WriteLine("Please enter your username below, then press enter");
                userName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Please enter your password below, then press enter");
                passWord = Convert.ToString(Console.ReadLine());
            }

            Console.ReadLine();

        }
    }
}
