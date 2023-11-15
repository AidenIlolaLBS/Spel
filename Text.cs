using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Text
{
    public void Menu()
    {
        int leaveMenu = 0;
        while (leaveMenu == 0)
        {
            Console.WriteLine("Welcome to game");
            Console.WriteLine("1. Start game\n" +
                              "2. Information\n" +
                              "3. Quit");
            Console.Write("Your input: ");
            switch (Console.ReadLine())
            {
                case "1":
                    leaveMenu = 1;
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("You will get different path choices where you will fight your way through different enemies\n" +
                                      "You can leave the program by writing quit when in the game\n" +
                                      "You can also write back to go back to the menu while in the game\n\n" +
                                      "Press any key to go back to the menu");
                    Console.ReadKey();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Your input can only contain 1, 2 or 3, press any key to try again");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
        }        
    }
    public void Inventory(List<string> items)
    {

    }
    public int Directions(string choice1, string choice2)
    { 
        bool down = false;
        while (!down)
        {
            Console.WriteLine("You have come to a split in the road");
            Console.WriteLine($"1. {choice1} path\n" +
                                $"2. {choice2} path\n");
            Console.Write("Your choice: ");
            switch (Console.ReadLine())
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "back":
                    return 0;
                case "leave":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Your input can only contain 1 or 2, press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        return 0;
    }
    public void Directions(string choice1, string choice2, string choice3)
    {

    }

    static public void Figthing(Character enemy)
    {
        Console.Clear();
        Console.WriteLine($"You have entered combat with {enemy.name}");    
    }

    public void Dialogue(string personName)
    {

    }
}

