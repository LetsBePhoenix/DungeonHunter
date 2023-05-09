internal class Program
{
    static Player Player1 = new Player("Player1", 20, 20, 1, 0);
    static Entity Wolf = new Entity("Wolf", "entity_wolf", 10, 20);
    static Weapon RustedDegger = new Weapon("Dolch", "weapon_degger_rusted", "weapon_degger", 7);
    static Weapon Sword = new Weapon("Sword", "weapon_sword", "weapon_sword", 10);

    private static void Main(string[] args)
    {
        Weapon EquippedWeapon = RustedDegger;
        Entity Opponent;
        Opponent = Wolf;
        Console.WriteLine(Opponent.HP);
        while (Opponent.HP != 0)
        {
            Player1.Attack(EquippedWeapon, Opponent);
            Console.WriteLine(Opponent.HP);
        }
        
    }
}