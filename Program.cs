using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables__HUD_v1._0_
{
    class Program
    {
        static float score;
        
        static int health;
        static int lives;
        static int shield;
        static string name;
        static int damage;
        static int pointsEarned;
        static int scoremultiplier;
        static int blockeddamage;
        static void Main(string[] args)
        {
            name = "Brianna Chisholm";
            score = 0;
            health = 150;
            lives = 2;
            shield = 100;
            damage = 0;
            pointsEarned = 0;
            scoremultiplier = 0;
            blockeddamage = 0;

            Console.WriteLine("//////////////////////");
            Console.WriteLine("// " + name +" //");
            Console.WriteLine("//////////////////////");
            Console.WriteLine();
            Console.WriteLine();
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            damage = 100;
            Console.WriteLine("Player got hit by a slime and took " + damage + " damage to health stat!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadKey(true);
            Console.WriteLine();
            TakeDamage(damage);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            blockeddamage = 100;
            Console.WriteLine("Slime attacks again, but the player blocks it with their Shield!");
            Console.WriteLine("Taken " + blockeddamage + " damage to Shield stat!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.ReadKey(true);
            ShieldDamage(blockeddamage);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            pointsEarned = 30;
            scoremultiplier = 5;
            AddScore(pointsEarned, scoremultiplier);
            Console.WriteLine("Player defeats Slime! Player earns " + pointsEarned + " points from the enemy with a score multiplier of " + scoremultiplier + "!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            Console.WriteLine();
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player encounters Bat!");
            Console.ReadKey(true);
            Console.WriteLine();
            damage = 50;
            Console.WriteLine("Bat attacks, dealing " + damage + " damage to the player!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            TakeDamage(damage);
            Console.WriteLine();
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            LiveRestock();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Due to Player Health hitting 0, a life has been lost...");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player Health has Replenished back to " + health + "!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            Console.WriteLine();
            
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            pointsEarned = 10;
            scoremultiplier = 5;
            AddScore(pointsEarned, scoremultiplier);
            Console.WriteLine("Player defeats Bat! Player earns " + pointsEarned + " points from the enemy with a score multiplier of " + scoremultiplier + "!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            Console.WriteLine();
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player escapes dungeon, mission complete, You Won!!!");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Game Is Over");
            

            Console.ReadKey(true);
        }
        static void ShowHUD()
        {
            Console.WriteLine("Current Stats");
            Console.WriteLine();
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + shield);
        }

        static void TakeDamage(int damage)
        {
            health = health - damage;
        }

        static void AddScore(int pointsEarned, int scoremultiplier)
        {
            score = score + pointsEarned * scoremultiplier;
        }

        static void ShieldDamage(int blockeddamage)
        {
            shield = shield - blockeddamage;
        }

        static void LiveRestock()
        {
            if (health <= 0)
            {
                lives = lives - 1;
                health = health + 150;
            }
        }
    }
}
