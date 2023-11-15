using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Combat
{
    static public bool Figth(Character enemy, Character player)
    {
        Text.Figthing(enemy);
        while (player.health > 0)
        {
            Console.WriteLine($"{enemy.name} has {enemy.health}hp");
            Console.WriteLine($"You have {player.health}hp");
            Console.WriteLine("You can:\n" +
                              "1. Attack\n" +
                              "2. Do nothing");
            switch (Console.ReadLine())
            {
                case "1":
                    enemy.health -= player.attack;
                    if (enemy.health <= 0)
                    {
                        player.health += 2;
                        if (player.health > player.maxHealth)
                        {
                            player.health = player.maxHealth;
                        }
                        return true;
                    }
                    break;
                case "2":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Your input can only be 1 or 2, press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
            }            
            player.health -= enemy.attack;
            Console.Clear();
        }
        return false;
    }
}
