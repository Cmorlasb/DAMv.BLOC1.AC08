using System;

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
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";

        int op = 0;
        int level = 1;
        int hours = 0;
        int days = 1;
        int point = 0;
        int points = 0;
        string wizard = "";
        bool validInput;

        Random rnd = new Random();

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
                    point = rnd.Next(1, 11);
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
        } while (op != 0);
    }

}