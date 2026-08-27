/*
 * Student ID : 1670317146
 * Name       : Dakanda Jaknarai
 * Section    : 129A
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine();

            string Name1 = "Yue";
            char rank1 = 'S';
            int level1 = 15;
            int maxHp1 = 8800;
            float damage1 = 569.9f;

            Console.WriteLine("Character01");
            Console.WriteLine($"Name: {Name1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"Level: {level1}");
            Console.WriteLine($"Hp: {maxHp1}");
            Console.WriteLine($"Damage: {damage1}");
            Console.WriteLine();

            string name2 = "Rouei";
            float damage = 57.9f;
            double critDamage = 9.55;
            char rank2 = 'S';
            int maxHp2 = 12000;

            Console.WriteLine("Character02");
            Console.WriteLine($"Name: {name2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"Damage: {damage}");
            Console.WriteLine($"CritDamge: {critDamage}");
            Console.WriteLine($"Hp: {maxHp2}");
            Console.WriteLine();

            string Name3 = "MaxNum";
            char rank3 = 'A';
            int level2 = 15;
            int maxHp3 = 13000;
            int Damage = 500;

            Console.WriteLine("Character03");
            Console.WriteLine($"Name: {Name3}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"Level: {level2}");
            Console.WriteLine($"Hp: {maxHp3}");
            Console.WriteLine($"Damage: {Damage}");
            Console.WriteLine();

            string Name4 = "Zip";
            char rank4 = 'A';
            int maxHp4 = 15000;
            bool isTank = true;
            int level3 = 15;

            Console.WriteLine("Character04");
            Console.WriteLine($"Name: {Name4}");
            Console.WriteLine($"Hp: {maxHp4}");
            Console.WriteLine($"isTank?: {isTank}");
            Console.WriteLine($"Level: {level3}");
        }
    }
}
