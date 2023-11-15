using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Character
{
    public string name = "";
    public int health;
    public int maxHealth;
    public int attack;
    
    public Character(string name, int health, int attack)
    {
        this.name = name;
        this.maxHealth = health;
        this.health = maxHealth;
        this.attack = attack;
    }
}
