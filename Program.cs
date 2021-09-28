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

        

        static void Main(string[] args)
        {
            name = "Brianna Chisholm";
            score = 0;
            health = 150;
            lives = 2;
            shield = 100;
            


            //Console.WriteLine(score * multiplier);
            Console.WriteLine("//////////////////////");
            Console.WriteLine("// " + name +" //");
            Console.WriteLine("//////////////////////");
            Console.WriteLine();
            Console.WriteLine();
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player got hit by a slime and took 100 damage to health stat!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadKey(true);
            Console.WriteLine();
            TakeDamage(100);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Slime attacks again, but the player blocks it with their Shield!");
            Console.WriteLine("Taken 100 damage to Shield stat!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.ReadKey(true);
            ShieldDamage(100);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player defeats Slime, earning 150 points to their Score!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            AddScore(30,5);
            Console.WriteLine();
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player encounters Bat!");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("Bat attacks, dealing 50 damage to the player!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            TakeDamage(50);
            Console.WriteLine();
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Due to Player Health hitting 0, a life has been lost...");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player Health has Replenished back to 150!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            Console.WriteLine();
            LiveRestock();
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player defeats Bat, earning 50 points to their Score!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            Console.WriteLine();
            AddScore(10,5);
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
