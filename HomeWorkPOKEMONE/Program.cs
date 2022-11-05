namespace HomeWorkPOKEMONE
{
    internal class Program
    {
        static void Main()
        {
            Pokemon Pikachu = new Pokemon(580, 54, 5, 23);
            Pokemon Ivi = new Pokemon(700, 55, 3, 20);
            while (Ivi.Health > 0 && Pikachu.Health > 0)
            {
                Console.WriteLine("Атка-Блок");
                Ivi.Defend(Pikachu);
                WriteHealth(Pikachu.Health, Ivi.Health);
                Console.WriteLine("Блок-Атака");
                Pikachu.Defend(Ivi);
                WriteHealth(Pikachu.Health, Ivi.Health);
                Console.WriteLine("Атка-Уворот");
                Ivi.Dodge(Pikachu);
                WriteHealth(Pikachu.Health, Ivi.Health);
                Console.WriteLine("Уворот-Атака");
                Pikachu.Dodge(Ivi);
                WriteHealth(Pikachu.Health, Ivi.Health);
            }
            if (Pikachu.Health > 0)
                Console.WriteLine("Победил Пикачу");
            else
                Console.WriteLine("Победид Иви");
        }
        static void WriteHealth(int Pikachu, int Ivi)
        {
            Console.WriteLine($"Здровье Пикачу:{Pikachu}, Здоровье Иви:{Ivi}");
        }
    }
    public class Pokemon
    {
        public int Health;
        public int Strength;
        public int Armor;
        public int Agility;

        public Pokemon(int health, int strength, int armor, int agility)
        {
            Health = health;
            Strength = strength;
            Armor = armor;
            Agility = agility;
        }
        public void Defend(Pokemon otherpokemon)
        {
            int Damage = otherpokemon.Strength - this.Armor;
            if (Damage < 0)
                this.Health -= 0;
            else
                this.Health -= Damage;
        }
        public void Dodge(Pokemon otherpokemon)
        {
            int Damage = otherpokemon.Strength - this.Agility;
            if (Damage < 0)
                this.Health -= 0;
            else
                this.Health -= Damage;
        }
    }
}