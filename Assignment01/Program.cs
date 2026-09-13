/*
 * Student ID : 1670317146
 * Name       : Dakanda Jaknarai
 * Section    : 129A
 * No.        : 2
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const string GameTitle = "ROV";

           
            string heroName = "Rouie";
            char skinTier = 'S';
            int baseMana = 430;
            float cooldownReduction = 15.5f;
            double baseArmor = 145.8;
            bool hasGlobalTeleport = true;

            
            var ultimateSkill = "Sacred Ground";
            var maxLevel = 15;

            
            double manaDouble = baseMana;

            
            int armorExplicit = (int)baseArmor;             
            int armorConvert = Convert.ToInt32(baseArmor);  

            
            Console.WriteLine("========================================");
            Console.WriteLine($"       {GameTitle} : HERO STAT CARD       ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Hero Name        : {heroName}");
            Console.WriteLine($"Ultimate Skill   : {ultimateSkill}");
            Console.WriteLine($"Skin Tier        : {skinTier}");
            Console.WriteLine($"Max Level        : {maxLevel}");
            Console.WriteLine($"Support Role     : {hasGlobalTeleport}");
            Console.WriteLine($"Cooldown Reduc.  : {cooldownReduction}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("          [ TYPE CONVERSION ]           ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Base Mana (int)           : {baseMana}");
            Console.WriteLine($"Mana (Implicit to double) : {manaDouble}");
            Console.WriteLine();
            Console.WriteLine($"Base Armor (Original)     : {baseArmor}");
            Console.WriteLine($"Armor (Explicit Cast)     : {armorExplicit} ");
            Console.WriteLine($"Armor (Convert.ToInt32)   : {armorConvert} ");
            Console.WriteLine("========================================");
        }
    }
}
