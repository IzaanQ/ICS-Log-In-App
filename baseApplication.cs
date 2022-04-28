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

            }

            if (userState == 'R')
            {
                Console.WriteLine("Please enter your username below, then press enter");
                userName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Please enter your password below, then press enter");
                passWord = Convert.ToString(Console.ReadLine());
            }

            TextWriter tw = new StreamWriter("C:/text/text.txt", true);
            tw.WriteLine(newUserName + newPassWord);
            tw.WriteLine(userName);
            tw.Close();

            char[] array = new char[9000];

            int counter = 0; 
            foreach (string line in System.IO.File.ReadLines(@"C:/text/text.txt"))
            {
                System.Console.WriteLine(line);
                counter++;
                for (int i = 0; i < line.Length; i++)
                {
                array[i] = line[i];
                }
            }

            string[] checkArray = new string[9000];
            string check = newUserName + newPassWord;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            
            
            Console.WriteLine(array);

            if (check == array[counter])
            {
            }
  




            Console.ReadLine();

        }
    }
}
