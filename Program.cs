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
            Console.WriteLine("What would you like to do?\n[1]View List of Players\n[2]Attack a player\n[3]View your stats");
        }
    }
}


