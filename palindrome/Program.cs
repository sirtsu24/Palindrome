using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;

            Console.WriteLine("Enter your name: ");
            userAnswer = Console.ReadLine();

            ReversedName(userAnswer);
           

            if (userAnswer.ToLower() == ReversedName(userAnswer).ToLower())
            {
                Console.WriteLine("It is a palindrome");
            }

            else
            {
                Console.WriteLine("It is not a palindrome");
            }


        }
        public static string ReversedName(string s)
        {
            char[] name = s.ToCharArray();
            Array.Reverse(name);
            return new string(name);
                      
        }
    }
    }