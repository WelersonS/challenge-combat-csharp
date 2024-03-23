
namespace ChallengeCombat
{
    internal class Champion
    {
        public string Name { get; private set; }
        public int Life { get; private set; }
        public int Attack { get; private set; }
        public int Armor { get; private set; }

        public Champion(string name, int life,  int attack, int armor)
        {
            Name = name;
            Life = life;
            Attack = attack;
            Armor = armor;
        }

        public void TakeDamage(Champion champion)
        {
            if (champion.Attack <= Armor)
                Life--;
            else
                Life -= (champion.Attack - Armor);

            if (Life < 0 )
                Life = 0;
        }

        public String Status()
        {
            if (Life > 0) 
                return $"{Name}: {Life} de vida";
            else
                return $"{Name}: {Life} de vida (morreu)";
        }
    }
}
