using System;
using System.ComponentModel.Design;

public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string WizardName = "What is her name?";
        const string WizardNameConf = "Wizard: ";
        const string Level = "Level: ";
        const string Hours = "How much time mediatation?";
        const string Meditation = "{0} go to the meditation";
        const string Days = "Day {0} --> {1}, has meditated {2} hours and the power is the {3}, points!";
        const string Points20 = "You have no idea what magic is.";
        const string PointsMore20 = "You still confuse the rod with a spoon";
        const string Points30 = "You are a Summoner of Magic Breezes.";
        const string PointsMore35 = "Wow! You can summon dragons without burning down the lab!";
        const string PointsMore40 = "You have reached the rank of Arcane Master!";
        const string Level20 = "You have obtained the rank: Raoden el Elantrí";
        const string LevelMore20 = "You have obtained the rank: Zyn el Buguejat";
        const string Level30 = "You have obtained the rank: Arka Nullpointer";
        const string LevelMore35 = "You have obtained the rank: Elarion de les Brases";
        const string LevelMore40 = "You have obtained the rank: ITB-Wizard el Gris";

        const string MenuOption2 = "2. Check the dungeon";
        const string DoorContext = "You have a door with a code in front of you.";
        const string Doors = "What is the code for this door?";
        const string Door = "Door {0}:";
        const string DoorWrong = "The dragon has detected your presence and has expelled you from the server!";
        const string DoorGood = "The dragon respects you. You have unlocked the next level!";
        const string DoorEnd = "You have unlocked the final level. Prepare for battle!";
        const string DoorBadEnd = "The dragon tree has eaten you without you even noticing.";

        const string MenuOption3 = "3. Loot the mine";
        const string Excavations = "You're in the mine, shall we start mining?";
        const string NoExvavations = "Aren't you going to dig today? Come on, give it a try.";
        const string NoCoins = "Today is not your lucky day, you found 0 bits.";
        const string WinCoins = "You’ve unlocked the gold GPU! Your spells now run at 120 FPS!";
        const string MinCoins = "Your magic card is still integrated. It's time to defeat another dragon!";
        const string Bitcoins = "On day {0} you have acquired {1} bitcoins.";
        const string TotalCoins = "You have a {0} bitcoins.";

        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";

        int op = 0;
        int level = 1;
        int hours = 0;
        int days = 1;
        int point = 0;
        int points = 0;
        int i = 0;
        int code = 0;
        int codes = 0;
        int door = 1; 
        int coin = 0;
        int coins = 0;
        int excavations = 1;
        int prob = 0;
        string wizard = "";
        string wanna = "";
        bool validInput;

        Random PointsRandom = new Random();
        Random CodeRandom = new Random();
        Random CoinsRandoms = new Random();

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            validInput = true;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (op == 1)
            {
                points = 0;
                days = 1;
                Console.WriteLine(WizardName);
                wizard = Console.ReadLine();
                Console.WriteLine(WizardNameConf + wizard);
                Console.WriteLine(Level + level);
                Console.WriteLine(Meditation, wizard);

                while (days < 6)
                {
                    Console.WriteLine(Hours);
                    hours = Convert.ToInt32(Console.ReadLine());
                    point = PointsRandom.Next(1, 11);
                    points += point;

                    Console.WriteLine(Days, days, wizard, hours, points);

                    days++;
                }
                if (points < 20)
                {
                    Console.WriteLine(Points20);
                    Console.WriteLine(Level20);
                }
                else if (points < 30)
                {
                    Console.WriteLine(PointsMore20);
                    Console.WriteLine(LevelMore20);
                }
                else if (points < 35)
                {
                    Console.WriteLine(Points30);
                    Console.WriteLine(Level30);
                }
                else if (points < 40)
                {
                    Console.WriteLine(PointsMore35);
                    Console.WriteLine(LevelMore35);
                }
                else
                {
                    Console.WriteLine(PointsMore40);
                    Console.WriteLine(LevelMore40);
                }
            }

            else if (op == 2)
            {
                i = 0;
                door = 1;
                codes = 0;
                Console.WriteLine(DoorContext);

                while (door < 4)
                {
                    i = 0;
                    Console.WriteLine(Door, door);
                    while (i < 3)
                    {
                        codes = CodeRandom.Next(1, 6);
                        Console.WriteLine(Doors);
                        code = Convert.ToInt32(Console.ReadLine());

                        if (code == codes)
                        {
                            Console.WriteLine(DoorGood);
                            door++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(DoorWrong);
                            i++;
                        }

                        if (i == 3)
                        {
                            Console.WriteLine(DoorBadEnd);
                            break;
                        }
                    }

                    if (i == 3)
                    {
                        break;
                    }
                }

                if (door == 4 && i < 3)
                {
                    Console.WriteLine(DoorEnd);
                }
            }

            else if (op == 3)
            {
                coins = 0;
                excavations = 1;
                Console.WriteLine(Excavations);
                wanna = Console.ReadLine();

                while (wanna.ToLower() == "no")
                {
                    Console.WriteLine(NoExvavations);
                    Console.WriteLine(Excavations);
                    wanna = Console.ReadLine();
                }
                while (excavations < 6)
                {
                    prob = CoinsRandoms.Next(1, 101);
                    coin = 0;

                    if (prob <= 10)
                    {
                        coin = 0;
                    }
                    else if (prob <= 85)
                    {
                        coin = CoinsRandoms.Next(41, 51);
                    }
                    else
                    {
                        coin = CoinsRandoms.Next(1, 41);
                    }
                    coins += coin;
                    Console.WriteLine(Bitcoins, excavations, coins);
                    excavations = excavations + 1;
                }
                Console.WriteLine(TotalCoins, coins);
                if (coins < 200)
                {
                    Console.WriteLine(MinCoins);
                }
                else if (coins == 0)
                {
                    Console.WriteLine(NoCoins);
                }
                else
                {
                    Console.WriteLine(WinCoins);
                }
            }
        } while (op != 0);
    }

}