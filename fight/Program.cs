using System;
using System.Threading;

namespace fight
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 100;
            int botHp = 100;

            string fighter1 = "";
            string fighter2 = "";
            int fighter2R;

            Random generator = new Random();

            string playerAttack = "";

            //Multipliers for player attacks
            int playerHitSpeed;
            int playerHitStrength;
            int playerHeal;
            int playerStun;
            int playerFail;

            int botAttack;
            string botAttackString = "";

            //Multipliers for Bot attacks
            int botHitSpeed;
            int botHitStrength;
            int botHeal;
            int botStun;
            int botFail;

            int coin = 10; //Player Coins

            intro();

            void intro(){
                playerHp = 100;
                botHp = 100;
                System.Console.WriteLine("Are you ready to RUMLE!!");
                System.Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("Coin: " + coin);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                while(fighter1.Length < 2 || fighter1.Length > 15)
                {
                    Console.Clear();
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
                Console.Clear();
                System.Console.WriteLine("IN THE LEFT CORNER WE GOT " + fighter1 + "!!!!");
                fighter2R = generator.Next(15);
            
                if(fighter2R == 0)
                {
                    fighter2 = "BOB";
                }

                else if(fighter2R == 1)
                {
                    fighter2 = "GOLIATH";
                }

                else if(fighter2R == 2)
                {
                    fighter2 = "DAVID";
                }

                else if(fighter2R == 3)
                {
                    fighter2 = "ALEX";
                }

                else if(fighter2R == 4)
                {
                    fighter2 = "THAT OTHER DUDE";
                }

                else if(fighter2R == 5)
                {
                    fighter2 = "MARIO";
                }

                else if(fighter2R == 6)
                {
                    fighter2 = "LIAM";
                }

                else if(fighter2R == 7)
                {
                    fighter2 = "WILLIAM";
                }

                else if(fighter2R == 8)
                {
                    fighter2 = "LUCIFER";
                }

                else if(fighter2R == 9)
                {
                    fighter2 = "GOD";
                }

                else if(fighter2R == 10)
                {
                    fighter2 = "HUNTER";
                }

                else if(fighter2R == 11)
                {
                    fighter2 = "ETHAN";
                }

                else if(fighter2R == 12)
                {
                    fighter2 = "BENJAMIN";
                }
                
                else if(fighter2R == 13)
                {
                    fighter2 = "OLIVER";
                }

                else if(fighter2R == 14)
                {
                    fighter2 = "MR VAN ARKEL";
                }

                System.Console.WriteLine("AAAANNND IN THE RIGHT CORNER WE HAVE " + fighter2 + "!!");
                fighter1 = fighter1.ToLower();
                fighter2 = fighter2.ToLower();
                Console.ReadLine();

                fight();
            }

            void betting(){
                System.Console.WriteLine("Do you want to bet ");
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
                while(playerHp > 0 && botHp > 0)
                {
                    while(playerAttack != "heavy" && playerAttack != "quick" && playerAttack != "magic" && playerAttack != "stun" && playerAttack != "heal" && playerHp > 0 && botHp > 0)
                    {
                        Console.Clear();
                        System.Console.WriteLine("What Attack do you want to use");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        System.Console.Write("Heavy");
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.Write(" | ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.Write("Quick");
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.Write(" | ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.Write("Magic");
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.Write(" | ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.Write("Stun");
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.Write(" | ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Heal");
                        Console.ForegroundColor = ConsoleColor.White;
                        playerAttack = Console.ReadLine();
                        playerAttack = playerAttack.ToLower();
                    }

                    if(playerAttack == "heavy")
                    {
                        playerHitSpeed = 1;
                        playerHitStrength = 2;
                        playerHeal = 0;
                        playerStun = 0;
                        playerFail = 1;
                    }
                    else if(playerAttack == "quick")
                    {
                        playerHitSpeed = 2;
                        playerHitStrength = 1;
                        playerHeal = 0;
                        playerStun = 0;
                        playerFail = 1;
                    }
                    else  if(playerAttack == "magic")
                    {
                        playerHitSpeed = 2;
                        playerHitStrength = 3;
                        playerHeal = 1;
                        playerStun = 0;
                        playerFail = 2;
                    }
                    else if(playerAttack == "stun")
                    {
                        playerHitSpeed = 2;
                        playerHitStrength = 0;
                        playerHeal = 0;
                        playerStun = 1;
                        playerFail = 1;
                    }
                    else if(playerAttack == "heal")
                    {
                        playerHitSpeed = 1;
                        playerHitStrength = 0;
                        playerHeal = 1;
                        playerStun = 0;
                        playerFail = 1;
                    }
                    else
                    {
                        playerHitSpeed = 0;
                        playerHitStrength = 0;
                        playerHeal = 0;
                        playerStun = 0;
                        playerFail = 0;
                        System.Console.WriteLine("Oh we fucked up");
                    }
    
                    playerHitSpeed = generator.Next(1, 11) * playerHitSpeed;
                    playerHitStrength = generator.Next(1, 11) * playerHitStrength;
                    playerHeal = generator.Next(1, 11) * playerHeal;
                    playerFail = generator.Next(1, 11) * playerFail;

                    botAttack = generator.Next(5);
                    if(botAttack == 0)
                    {
                        botHitSpeed = 1;
                        botHitStrength = 2;
                        botHeal = 0;
                        botStun = 0;
                        botFail = 1;
                        botAttackString = "heavy";
                    }
                    else if(botAttack == 1)
                    {
                        botHitSpeed = 2;
                        botHitStrength = 1;
                        botHeal = 0;
                        botStun = 0;
                        botFail = 1;
                        botAttackString = "quick";
                    }
                    else if(botAttack == 2)
                    {
                        botHitSpeed = 2;
                        botHitStrength = 3;
                        botHeal = 1;
                        botStun = 0;
                        botFail = 2;
                        botAttackString = "magic";
                    }
                    else if(botAttack == 3)
                    {
                        botHitSpeed = 2;
                        botHitStrength = 0;
                        botHeal = 0;
                        botStun = 1;
                        botFail = 1;
                        botAttackString = "stun";
                    }
                    else if(botAttack == 4)
                    {
                        botHitSpeed = 1;
                        botHitStrength = 0;
                        botHeal = 3;
                        botStun = 0;
                        botFail = 1;
                        botAttackString = "heal";
                    }
                    else
                    {
                        botHitSpeed = 0;
                        botHitStrength = 0;
                        botHeal = 0;
                        botStun = 0;
                        botFail = 0;
                        System.Console.WriteLine("Oh we fucked up");
                    }
 
                    botHitSpeed = generator.Next(1, 11) * botHitSpeed;
                    botHitStrength = generator.Next(1, 11) * botHitStrength;
                    botHeal = generator.Next(1, 11) * botHeal;
                    botFail = generator.Next(1, 11) * botFail;

                    if(playerHitSpeed == botHitSpeed)
                    {
                        botHitSpeed = generator.Next(1000);
                        playerHitSpeed = generator.Next(1000);
                    }

                    if(playerHitSpeed > botHitSpeed) //Player goes first
                    {
                        botHp -= playerHitStrength;
                        playerHp += playerHeal;
                        if(playerAttack != "heal" && playerAttack != "stun")
                        {
                            System.Console.Write(fighter1 + " hits " + fighter2 + " with a ");
                            if(playerAttack == "heavy"){Console.ForegroundColor = ConsoleColor.DarkGray;}
                            if(playerAttack == "quick"){Console.ForegroundColor = ConsoleColor.Blue;}
                            if(playerAttack == "stun"){Console.ForegroundColor = ConsoleColor.Green;}
                            System.Console.Write(playerAttack);
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine(" attack");
                            System.Console.WriteLine(fighter2 + " is now at ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.Write(botHp);
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine(" Health");
                            
                        }
                        if(playerAttack == "heal")
                        {
                            System.Console.Write(fighter1 + " heals and brings his hp to ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.Write(playerHp);
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine(" Health");
                        }
                        if(playerAttack == "stun")
                        {

                        }

                        if(botHp >=0)
                        {
                            playerHp -= botHitStrength;
                            botHp += botHeal;
                            if(botAttackString != "heal" && botAttackString != "stun")
                            {
                                System.Console.Write(fighter2 + " hits " + fighter1 + " with a ");
                                if(botAttackString == "heavy"){Console.ForegroundColor = ConsoleColor.DarkGray;}
                                if(botAttackString == "quick"){Console.ForegroundColor = ConsoleColor.Blue;}
                                if(botAttackString == "stun"){Console.ForegroundColor = ConsoleColor.Green;}
                                System.Console.Write(botAttackString);
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine(" attack");
                                System.Console.WriteLine(fighter1 + " is now at ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.Write(playerHp);
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine(" Health");
                            }
                            if(botAttackString == "heal")
                            {
                                System.Console.Write(fighter2 + " heals and brings his hp to ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.Write(botHp);
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine(" Health");
                            }
                            if(botAttackString == "stun")
                            {

                            }
                        }
                    }
                    else //Bot goes first
                    {
                        playerHp -= botHitStrength;
                        botHp += botHeal;
                        if(botAttackString != "heal" && botAttackString != "stun")
                        {
                            System.Console.Write(fighter2 + " hits " + fighter1 + " with a ");
                            if(botAttackString == "heavy"){Console.ForegroundColor = ConsoleColor.DarkGray;}
                            if(botAttackString == "quick"){Console.ForegroundColor = ConsoleColor.Blue;}
                            if(botAttackString == "stun"){Console.ForegroundColor = ConsoleColor.Green;}
                            System.Console.Write(botAttackString);
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine(" attack");
                            System.Console.Write(fighter1 + " is now at ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.Write(playerHp);
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine(" Health");
                        }
                        if(botAttackString == "heal")
                        {
                            System.Console.Write(fighter2 + " heals and brings his hp to ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.Write(botHp);
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine(" Health");
                        }
                        if(botAttackString == "stun")
                        {

                        }
                        if(playerHp >= 0)
                        {
                            botHp -= playerHitStrength;
                            playerHp += playerHeal;
                            if(playerAttack != "heal" && playerAttack != "stun")
                            {
                                System.Console.Write(fighter1 + " hits " + fighter2 + " with a ");
                                if(playerAttack == "heavy"){Console.ForegroundColor = ConsoleColor.DarkGray;}
                                if(playerAttack == "quick"){Console.ForegroundColor = ConsoleColor.Blue;}
                                if(playerAttack == "stun"){Console.ForegroundColor = ConsoleColor.Green;}
                                System.Console.Write(playerAttack);
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine(" attack");
                                System.Console.WriteLine(fighter2 + " is now at ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.Write(botHp);
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine(" Health");
                            }
                            if(playerAttack == "heal")
                            {
                                System.Console.Write(fighter1 + " heals and brings his hp to ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.Write(playerHp);
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine(" Health");
                            }
                            if(playerAttack == "stun")
                            {

                            }
                        }
                    }
                    Console.ReadLine();
                    playerAttack = "";
                }
                endFight();
            }
            
            void endFight(){
                if(playerHp <= 0 && botHp <= 0)
                {
                    System.Console.WriteLine("Both Fighters are down and its a DRAW!!");
                    System.Console.WriteLine("Goodbye people and come for the next fight TOMORROW!");
                    Console.ReadLine();
                    wakeUp();
                }
                else if(playerHp <= 0)
                {
                    System.Console.WriteLine(fighter1 + " is down and " + fighter2 + " is the WINNER!");
                    Console.ReadLine();
                    wakeUp();
                }
                else if(botHp <= 0)
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
