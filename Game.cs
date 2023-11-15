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
        bool back;

        while (!exitGame)
        {
            back = false;
            text.Menu();
            while (!back)
            {
                switch (text.Directions("easy", "hard"))
                {
                    case 0:
                        back = true;
                        break;
                    case 1:
                        Character enemy = new("Goblin", 5, 1);
                        Character player = new("Player", 20, 3);
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
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("You killed all enemys");
                        Console.ReadLine();
                        break;
                    case 2:

                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }        
    }
}

