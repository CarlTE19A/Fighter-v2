using System;
using System.Threading;

namespace fight
{
    class Program
    {
        static void Main(string[] args)
        {
            int fighter1Hp = 100;
            int fighter2Hp = 100;

            string fighter1 = "";
            string fighter2 = "";
            int fighter2R;

            Random generator = new Random();

            int fightS1;
            int fightS2;

            intro();

            void intro(){
                fighter1Hp = 100;
                fighter2Hp = 100;
                System.Console.WriteLine("Are you ready to RUMLE!!");
                Console.ReadLine();
                Console.Clear();
                while(fighter1.Length < 2 || fighter1.Length > 15)
                {
                    System.Console.WriteLine("*Whats your name kid?");
                    fighter1 = Console.ReadLine();
                    if(fighter1.Length < 2)
                    {
                        System.Console.WriteLine("That name is too short, won't sound good announsing");
                        System.Console.WriteLine("Get a nickname!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if(fighter1.Length > 15)
                    {
                        System.Console.WriteLine("That name is too long, won't sound good announsing");
                        System.Console.WriteLine("Get a nickname!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                fighter1 = fighter1.ToUpper();
                System.Console.WriteLine("IN THE LEFT CORNER WE GOT " + fighter1 + "!!!!");
                fighter2R = generator.Next(3);
            
                if(fighter2R == 0)
                {
                    fighter2 = "BOB";
                }

                if(fighter2R == 1)
                {
                    fighter2 = "GOLIATH";
                }

                if(fighter2R == 2)
                {
                    fighter2 = "DAVID";
                }

                System.Console.WriteLine("AAAANNND IN THE RIGHT CORNER WE HAVE " + fighter2 + "!!");
                fighter1 = fighter1.ToLower();
                fighter2 = fighter2.ToLower();
                Console.ReadLine();

                fight();
            }

            void fight(){
                Console.Clear();
                System.Console.WriteLine("THREE!");
                Thread.Sleep(500);
                System.Console.WriteLine("TWO!");
                Thread.Sleep(400);
                System.Console.WriteLine("ONE!!");
                Thread.Sleep(300);
                System.Console.WriteLine("FIGHT!!!!");
                System.Console.WriteLine("");
                while(fighter1Hp > 0 && fighter2Hp > 0){
                    fightS1 = generator.Next(26);
                    fightS2 = generator.Next(26);
                    fighter1Hp -= fightS2;
                    fighter2Hp -= fightS1;
                    if(fighter1Hp < 0)
                    {
                        fighter1Hp = 0;
                    }

                    if(fighter2Hp < 0)
                    {
                        fighter2Hp = 0;
                    }

                    if(fightS1 > fightS2)
                    {
                        System.Console.WriteLine(fighter1 + " got in a good hit taking " + fighter2 + " to " + fighter2Hp + " health!");
                        System.Console.WriteLine(fighter2 + " at least got in a hit and took " + fighter1 + " to " + fighter1Hp + " health!");
                    }
                    else if(fightS1 < fightS2)
                    {
                        System.Console.WriteLine(fighter2 + " got in a good hit taking " + fighter1 + " to " + fighter1Hp + " health!");
                        System.Console.WriteLine(fighter1 + " at least got in a hit and took " + fighter2 + " to " + fighter2Hp + " health!");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                endFight();
            }
            
            void endFight(){
                if(fighter1Hp == 0 && fighter2Hp == 0)
                {
                    System.Console.WriteLine("Both Fighters are down and its a DRAW!!");
                    System.Console.WriteLine("Goodbye people and come for the next fight TOMORROW!");
                    Console.ReadLine();
                    wakeUp();
                }
                else if(fighter1Hp == 0)
                {
                    System.Console.WriteLine(fighter1 + " is down and " + fighter2 + " is the WINNER!");
                    Console.ReadLine();
                    wakeUp();
                }
                else if(fighter2Hp == 0)
                {
                    System.Console.WriteLine(fighter2 + " is down and " + fighter1 + " is the WINNER!");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("PEOPLE! DO WE WANT ANOTHER FIGHT!!?");
                    System.Console.WriteLine("YEEEES!!!!");
                    string again = "";
                    while(again != "1" && again != "2")
                    {
                        System.Console.WriteLine("You up " + fighter1 + "?");
                        System.Console.WriteLine("[1] for yes or [2] for no");
                        again = Console.ReadLine();
                        Console.Clear();
                    }
                    if(again == "1"){intro();}
                }
            }
        
            void wakeUp()
            {
                System.Console.WriteLine("Hey, you. You're finally awake.");
                System.Console.WriteLine("You were trying to cross the border, right?");
                System.Console.WriteLine("Ah just kidding this isn't Skyrim");
                System.Console.WriteLine("You got hit hard last night, time to pay your debt now.");

                string again = "";
                    while(again != "1" && again != "2")
                    {
                        System.Console.WriteLine("Ready to fight " + fighter1 + "?");
                        System.Console.WriteLine("[1] for yes or [2] for no");
                        again = Console.ReadLine();
                        Console.Clear();
                    }
                    if(again == "1"){intro();}
            }
        }
    }
}
