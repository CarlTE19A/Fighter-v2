﻿using System;
using System.Threading;

namespace fight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figter Hp
            int playerHp = 100;
            int botHp = 100;
            
            //Fighter Names
            string fighter1 = "";
            string fighter2 = "";

            Random generator = new Random();

            string playerAttack = "";

            //Multipliers for player attacks
            int playerHitSpeed;
            int playerHitStrength;
            int playerHeal;
            int playerFail;
            
            //What the bot does
            int fighter2R; //What bot is fighting
            int botAttack;
            string botAttackString = "";

            //Multipliers for Bot attacks
            int botHitSpeed;
            int botHitStrength;
            int botHeal;
            int botFail;

            int coin = 10; //Player Coins
            int betInt = 0;  //How much the player bets

            //To tell the player about what they have done
            int resultHeavy = 0; int resultHeavyTotal = 0;
            int resultQuick = 0; int resultQuickTotal = 0;
            int resultMagic = 0; int resultMagicTotal = 0;
            int resultHeal = 0; int resultHealTotal = 0;
            int resultFailure = 0; 

            intro();

            void intro() //The Start of every match
            {
                playerHp = 100;
                botHp = 100;
                System.Console.WriteLine("Are you ready to RUMLE!!");
                Thread.Sleep(1000);
                while(fighter1.Length < 2 || fighter1.Length > 15) //Name function with a min and max length
                {
                    Console.Clear();
                    System.Console.WriteLine("*Whats your name kid?");
                    fighter1 = Console.ReadLine();

                    if(fighter1.Length < 2) //If the name is to short
                    {
                        System.Console.WriteLine("That name is too short, won't sound good announsing");
                        System.Console.WriteLine("Get a nickname!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if(fighter1.Length > 15) //If the name is to long
                    {
                        System.Console.WriteLine("That name is too long, won't sound good announsing");
                        System.Console.WriteLine("Get a nickname!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                fighter1 = fighter1.ToUpper(); //To annonuce the name in CAPS
                Console.Clear();

                if(coin>0) //If the player has coins to bet, they can
                {
                    betting();
                }

                System.Console.WriteLine("IN THE LEFT CORNER WE GOT " + fighter1 + "!!!!");
                fighter2R = generator.Next(15); //Randomizes bot name
            
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
                //Sets both figthers names to lower case for the rest of the fight
                fighter1 = fighter1.ToLower();
                fighter2 = fighter2.ToLower();
                Console.ReadLine();

                fight(); //starts the Fight
            }

            void betting() //If the player chooses to bet on the fight
            {
                string bet = "";
                string betString = "";
            
                while(bet != "1" && bet != "2") //If the player wants to bet on the fight
                {
                    System.Console.WriteLine("Do you want to bet any coin on your fight");
                    System.Console.WriteLine("If you win I will dubble your investment");
                    System.Console.WriteLine("[1] for yes or [2] for no");
                    System.Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    System.Console.WriteLine("Coin: " + coin);
                    Console.ForegroundColor = ConsoleColor.White;
                    bet = Console.ReadLine();
                    Console.Clear();
                }
                if(bet=="1") //
                {
                    betInt = 0;
                    while( betInt > coin || betInt < 1) //So if the player choose to bet they cant bet 0 or less and not more then they have
                    {
                        System.Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        System.Console.WriteLine("Coin: " + coin);
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.WriteLine("");
                        System.Console.WriteLine("How much do you want to bet then?");
                        betString = Console.ReadLine();
                        try //converts bet string to int
                        {
                            betInt = int.Parse(betString);
                            if(betInt<1) //They bet to little
                            {
                                System.Console.WriteLine("You cant bet nothing");
                            }
                            else if(betInt>coin) //They bet to much
                            {
                                System.Console.WriteLine("You dont have the coin kid");
                            }
                            else
                            {
                                System.Console.WriteLine("Very Good");
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                        catch //They dont put in a correct string
                        {
                            System.Console.WriteLine("You need to tell me how much you want to bet");
                        }
                    }
                    coin -= betInt; //Their coin is redused with thier bet
                    //The next part is used multiple times to show how much coin the player got
                    System.Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    System.Console.WriteLine("Coin: " + coin);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }

            void fight() //The Fight
            {
                //Countdown
                Console.Clear();
                System.Console.WriteLine("THREE!");
                Thread.Sleep(500);
                System.Console.WriteLine("TWO!");
                Thread.Sleep(400);
                System.Console.WriteLine("ONE!!");
                Thread.Sleep(300);
                System.Console.WriteLine("FIGHT!!!!");

                while(playerHp > 0 && botHp > 0) //If either fighter has any health, almost redundant and could be integrated in the next while loop
                {
                    while(playerAttack != "heavy" && playerAttack != "quick" && playerAttack != "magic" && playerAttack != "heal" && playerHp > 0 && botHp > 0) //The player uses a attack
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Heal");
                        Console.ForegroundColor = ConsoleColor.White;
                        playerAttack = Console.ReadLine();
                        playerAttack = playerAttack.ToLower();
                    }

                    if(playerAttack == "heavy") //If player use a heavy attack
                    {
                        playerHitSpeed = 1;
                        playerHitStrength = 2;
                        playerHeal = 0;
                        playerFail = 1;
                        resultHeavy +=1;
                    }
                    else if(playerAttack == "quick") //If player use a quick attack
                    {
                        playerHitSpeed = 2;
                        playerHitStrength = 1;
                        playerHeal = 0;
                        playerFail = 1;
                        resultQuick+=1;
                    }
                    else  if(playerAttack == "magic") //If player use a heavy attack
                    {
                        playerHitSpeed = 2;
                        playerHitStrength = 3;
                        playerHeal = 0;
                        playerFail = 2;
                        resultMagic+=1;
                    }
                    else if(playerAttack == "heal") //If player heals
                    {
                        playerHitSpeed = 1;
                        playerHitStrength = 0;
                        playerHeal = 2;
                        playerFail = 1;
                        resultHeal +=1;
                    }
                    else  //If the player breaks something
                    {
                        playerHitSpeed = 0;
                        playerHitStrength = 0;
                        playerHeal = 0;
                        playerFail = 0;
                        System.Console.WriteLine("Oh we fucked up");
                    }

                    //Randomizes player damage
                    playerHitSpeed = generator.Next(1, 11) * playerHitSpeed;
                    playerHitStrength = generator.Next(1, 11) * playerHitStrength;
                    playerHeal = generator.Next(1, 11) * playerHeal;
                    playerFail = generator.Next(1, 11) * playerFail;

                    botAttack = generator.Next(4);
                    if(botAttack == 0)  //If bot use a heavy attack
                    {
                        botHitSpeed = 1;
                        botHitStrength = 2;
                        botHeal = 0;
                        botFail = 1;
                        botAttackString = "heavy";
                    }
                    else if(botAttack == 1)  //If bot use a quick attack
                    {
                        botHitSpeed = 2;
                        botHitStrength = 1;
                        botHeal = 0;
                        botFail = 1;
                        botAttackString = "quick";
                    }
                    else if(botAttack == 2)  //If bot use a magic attack
                    {
                        botHitSpeed = 2;
                        botHitStrength = 3;
                        botHeal = 0;
                        botFail = 2;
                        botAttackString = "magic";
                    }
                    else if(botAttack == 3)  //If bot heals
                    {
                        botHitSpeed = 1;
                        botHitStrength = 0;
                        botHeal = 2;
                        botFail = 1;
                        botAttackString = "heal";
                    }
                    else //If something goes wrong
                    {
                        botHitSpeed = 0;
                        botHitStrength = 0;
                        botHeal = 0;
                        botFail = 0;
                        System.Console.WriteLine("Oh we fucked up");
                    }

                    //Bot Randomizer
                    botHitSpeed = generator.Next(1, 11) * botHitSpeed;
                    botHitStrength = generator.Next(1, 11) * botHitStrength;
                    botHeal = generator.Next(1, 11) * botHeal;
                    botFail = generator.Next(1, 11) * botFail;
                   
                    if(botFail >= 9) //bot fails thir move
                    {
                        botHitSpeed = 0;
                        botHitStrength = 0;
                        botHeal = 0;
                        botFail = 0;
                        botAttackString = "Failed";
                    }
                    if(playerFail >= 9) //player fails their move
                    {
                        playerHitSpeed = 0;
                        playerHitStrength = 0;
                        playerHeal = 0;
                        playerFail = 0;
                        playerAttack = "Failed";
                        resultFailure +=1;
                    }

                    while(playerHitSpeed == botHitSpeed) //If players speed and bot speed is the same, both are randomized
                    {
                        botHitSpeed = generator.Next(1000);
                        playerHitSpeed = generator.Next(1000);
                    }

                    if(playerHitSpeed > botHitSpeed) //If player is faster they go first
                    {
                        botHp -= playerHitStrength;
                        playerHp += playerHeal;
                        if(playerAttack != "heal") //If player attacks in some way
                        {
                            //Tells what the player does
                            System.Console.Write(fighter1 + " hits " + fighter2 + " with a ");
                            if(playerAttack == "heavy"){Console.ForegroundColor = ConsoleColor.DarkGray; resultHeavyTotal +=playerHitStrength;}
                            if(playerAttack == "quick"){Console.ForegroundColor = ConsoleColor.Blue; resultQuickTotal +=playerHitStrength;}
                            if(playerAttack == "magic"){Console.ForegroundColor = ConsoleColor.Green; resultMagicTotal +=playerHitStrength;}
                            if(playerAttack == "Failed"){Console.ForegroundColor = ConsoleColor.DarkRed;}
                            System.Console.Write(playerAttack);
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine(" attack");
                            System.Console.WriteLine(fighter2 + " is now at ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.Write(botHp);
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine(" Health");
                            
                        }
                        if(playerAttack == "heal") //If player heals
                        {
                            System.Console.Write(fighter1 + " heals and brings his hp to ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.Write(playerHp);
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.WriteLine(" Health");
                            resultHealTotal += playerHeal;
                        }

                        if(botHp >=0) //If bot is still alive its thier turn
                        {
                            playerHp -= botHitStrength;
                            botHp += botHeal;
                            if(botAttackString != "heal")
                            {
                                System.Console.Write(fighter2 + " hits " + fighter1 + " with a ");
                                if(botAttackString == "heavy"){Console.ForegroundColor = ConsoleColor.DarkGray;}
                                if(botAttackString == "quick"){Console.ForegroundColor = ConsoleColor.Blue;}
                                if(botAttackString == "magic"){Console.ForegroundColor = ConsoleColor.Green;}
                                if(botAttackString == "Failed"){Console.ForegroundColor = ConsoleColor.DarkRed;}
                                System.Console.Write(botAttackString);
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine(" attack");
                                System.Console.WriteLine(fighter1 + " is now at ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.Write(playerHp);
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine(" Health");
                            }
                            if(botAttackString == "heal") //If bot heals
                            {
                                System.Console.Write(fighter2 + " heals and brings his hp to ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.Write(botHp);
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Console.WriteLine(" Health");
                            }
                        }
                    }
                    else //Bot goes first (Same as last part but reversed)
                    {
                        playerHp -= botHitStrength;
                        botHp += botHeal;
                        if(botAttackString != "heal")
                        {
                            System.Console.Write(fighter2 + " hits " + fighter1 + " with a ");
                            if(botAttackString == "heavy"){Console.ForegroundColor = ConsoleColor.DarkGray;}
                            if(botAttackString == "quick"){Console.ForegroundColor = ConsoleColor.Blue;}
                            if(botAttackString == "magic"){Console.ForegroundColor = ConsoleColor.Green;}
                            if(botAttackString == "Failed"){Console.ForegroundColor = ConsoleColor.DarkRed;}
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

                        if(playerHp >= 0)
                        {
                            botHp -= playerHitStrength;
                            playerHp += playerHeal;
                            if(playerAttack != "heal")
                            {
                                System.Console.Write(fighter1 + " hits " + fighter2 + " with a ");
                                if(playerAttack == "heavy"){Console.ForegroundColor = ConsoleColor.DarkGray;}
                                if(playerAttack == "quick"){Console.ForegroundColor = ConsoleColor.Blue;}
                                if(playerAttack == "magic"){Console.ForegroundColor = ConsoleColor.Green;}
                                if(playerAttack == "Failed"){Console.ForegroundColor = ConsoleColor.DarkRed;}
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
                        }
                    }
                    Console.ReadLine();
                    playerAttack = "";
                }
                endFight(); //Someone won and fight ended
            }
            
            void endFight()
            {
                if(playerHp <= 0 && botHp <= 0) //If both are knocked out, (Should be redundant by now)
                {
                    System.Console.WriteLine("Both Fighters are down and its a DRAW!!");
                    System.Console.WriteLine("Goodbye people and come for the next fight TOMORROW!");
                    Console.ReadLine();
                    wakeUp();
                }
                else if(playerHp <= 0) //If player Losses
                {
                    System.Console.WriteLine(fighter1 + " is down and " + fighter2 + " is the WINNER!");
                    Console.ReadLine();
                    coin-=5; //For lossing fight
                    wakeUp();
                }
                else if(botHp <= 0) //If player Wins
                {
                    System.Console.WriteLine(fighter2 + " is down and " + fighter1 + " is the WINNER!");
                    System.Console.WriteLine("");
                    coin += betInt*2;
                    coin += 5; //For winning fight
                    if(betInt != 0) //If player bet money
                    {
                        System.Console.Write("Your bet was: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        System.Console.WriteLine(betInt + " coins");
                        System.Console.WriteLine("+" + betInt*2 + " coins");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    System.Console.WriteLine("+5");
                    System.Console.WriteLine("Coin: " + coin);
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine("");
                    System.Console.WriteLine("PEOPLE! DO WE WANT ANOTHER FIGHT!!?");
                    System.Console.WriteLine("YEEEES!!!!");
                    string again = "";
                    while(again != "1" && again != "2") //If player wants to fight again
                    {
                        System.Console.WriteLine("You up " + fighter1 + "?");
                        System.Console.WriteLine("[1] for yes or [2] for no");
                        again = Console.ReadLine();
                        Console.Clear();
                    }
                    if(again == "1")
                    {
                        intro();
                    }
                    else if(again == "2")
                    {
                        Leave();
                    }
                }
            }
        
            void wakeUp() //Player lost fight and wake up the next day
            {
                System.Console.WriteLine("Hey, you. You're finally awake.");
                System.Console.WriteLine("You were trying to cross the border, right?");
                System.Console.WriteLine("Ah just kidding this isn't Skyrim");
                System.Console.WriteLine("You got hit hard last night, but you need to stand up again");
                Console.ReadLine();
                Console.Clear();
                if(coin<0) //If the player has negative cash they are forced to continue fighting
                {
                    System.Console.WriteLine("You are in debt son");
                    System.Console.WriteLine("Time to pay up by actully winning a fight");
                    Console.ReadLine();
                    Console.Clear();
                    intro();
                }
                else //If player dosent have negative cash
                {
                    string again = "";
                    while(again != "1" && again != "2") //If the player wants to fight again
                    {
                        System.Console.WriteLine("Ready to fight " + fighter1 + "?");
                        System.Console.WriteLine("[1] for yes or [2] for no");
                        again = Console.ReadLine();
                        Console.Clear();
                    }
                    if(again == "1")
                    {
                        betting();
                        intro();
                    }
                    else if(again == "2")
                    {
                        Leave();
                    }    
                }
            }

            void Leave() //The player choose to stop fighting
            {
                System.Console.WriteLine("So you are leaving us " + fighter1);
                System.Console.WriteLine("I am sad to lose such a fighter as yourself");
                Console.ReadLine();
                Console.Clear();

                //How much cash the player had left
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                System.Console.Write("Coins: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine(coin);

                //How many times player used diffrent moves
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write("Heavy Attacks: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                System.Console.Write(resultHeavy);
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write(" with total damage of: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                System.Console.WriteLine(resultHeavyTotal);

                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write("Quick Attacks: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.Write(resultQuick);
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write(" with total damage of: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine(resultQuickTotal);

                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write("Magic Attacks: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                System.Console.Write(resultMagic);
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write(" with total damage of: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                System.Console.WriteLine(resultMagicTotal);

                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write("Healed: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.Write(resultHeal);
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write(" with total HP increase of: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine(resultHealTotal);

                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write("Failed Attacks: ");
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(resultFailure);
                Console.ForegroundColor = ConsoleColor.White;

                System.Console.WriteLine("");

                System.Console.WriteLine("Thank you for playing");

                Console.ReadLine();
            }
        }
    }
}
