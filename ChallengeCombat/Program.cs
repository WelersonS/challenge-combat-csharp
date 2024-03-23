namespace ChallengeCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int life, attack, armor;

            Console.WriteLine("Digite os dados do primeiro campeão:");
            Console.Write("Nome: ");
            name = Console.ReadLine();

            Console.Write("Vida inicial: ");
            life = int.Parse(Console.ReadLine());

            Console.Write("Ataque: ");
            attack = int.Parse(Console.ReadLine());

            Console.Write("Armadura: ");
            armor = int.Parse(Console.ReadLine());

            Champion championA = new Champion(name, life, attack, armor);

            Console.WriteLine();
            Console.WriteLine("Digite os dados do segundo campeão:");
            Console.Write("Nome: ");
            name = Console.ReadLine();

            Console.Write("Vida inicial: ");
            life = int.Parse(Console.ReadLine());

            Console.Write("Ataque: ");
            attack = int.Parse(Console.ReadLine());

            Console.Write("Armadura: ");
            armor = int.Parse(Console.ReadLine());

            Champion championB = new Champion(name, life, attack, armor);

            Console.WriteLine();
            Console.Write("Quantos turnos você deseja executar? ");
            int round = int.Parse(Console.ReadLine());

            //combat result
            for (int i = 1; i <= round; i++) 
            {
                championA.TakeDamage(championB);
                championB.TakeDamage(championA);

                Console.WriteLine();
                Console.WriteLine($"Resultado do turno {i}:");
                Console.WriteLine(championA.Status());
                Console.WriteLine(championB.Status());

                if (championA.Life == 0 || championB.Life == 0)
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("FIM DO COMBATE");
        }
    }
}