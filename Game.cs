using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Game
{

    static public void Run()
    {
        Text text = new();
        bool exitGame = false;
        int counter = 0;

        while (!exitGame)
        {
            text.Menu();
            //While the player has not reached 20 total crossroads
            while (counter != 20)
            {
                //Gives the user two different choices an easy and a hard
                switch (text.Directions("easy", "hard"))
                {
                    //Go back to the menu
                    case 0:
                        counter = 20;
                        break;
                    //Easy choice
                    case 1:
                        Entities enemy = Entities.Goblin();
                        Entities player = new("Player", 20, 3);
                        for (int i = 0; i < 3; i++)
                        {
                            enemy.health = enemy.maxHealth;
                            if (Combat.Figth(enemy, player) == true)
                            {
                                Console.Clear();
                                Console.WriteLine("You won");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You died");
                                Console.ReadKey();
                                break;
                            }
                        }
                        Console.Clear();
                        //Checks if the player is alive or not
                        if (player.health > 0)
                        {
                            Console.WriteLine("You killed all enemys");
                        }
                        else
                        {
                            Console.WriteLine("You failed");
                        }
                        Console.ReadLine();
                        break;
                    //Hard choice
                    case 2:

                        break;
                    default:
                        break;
                }
                counter++;
                Console.Clear();
            }
        }
    }
}