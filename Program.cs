using System;

namespace war
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name here:");
            string userName = Console.ReadLine();
            Console.WriteLine("Thank you {0}, now type your email:", userName);
            string userEmail = Console.ReadLine();
            var NewClan = new ClanCreation(userName, userEmail);
            Console.Clear();
            NewClan.WhatToDo();
        }
    }
}


