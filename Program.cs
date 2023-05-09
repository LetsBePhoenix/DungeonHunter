internal class Program
{
    static Player Player1 = new Player("Player1", 20, 20, 1, 0, 100);
    static Entity Wolf = new Entity("Wolf", "entity_wolf", 10, 20);
    static Weapon RustedDegger = new Weapon("Dolch", "weapon_degger_rusted", "weapon_degger", 7);
    static Weapon Sword = new Weapon("Sword", "weapon_sword", "weapon_sword", 10);
    public static Item WolfSkin = new Item("Wolfsfell", "item_skin_wolf", 0, 100);
    static Amor WolfAmor = new Amor("Wolfsrüstung", "amor_wolf", 0, 5);
    static Item HealPotion = new Item("Heilungstrank", "potion_healing", 0, 20);

    private static void Main(string[] args)
    {
        string choose;
        Weapon MainWeapon = RustedDegger;
        Console.Write("Was möchtest du tuhen\n");
        choose = Console.ReadLine();
        switch(choose)
        {
            case "1":
                Hunt(MainWeapon);
                break;
            case "2":
                break;
        }
    }
    private static void Hunt(Weapon MainWeapon)
    {
        Entity opponent;
        opponent = Wolf;
        switch (opponent)
        {
            case Entity Wolf:
                Console.WriteLine("Dein Gegner ist ein Wolf");
                break;
        }
        while(opponent.HP != 0)
        {
            Player1.Attack(MainWeapon, opponent);
        }
        Console.WriteLine("Du hast deinen Gegner besiegt!");
    }
    private void Craft(string ID_of_the_item)
    {
        switch(ID_of_the_item)
        {
            case "amor_wolf":
                if (WolfSkin.Ammount >= 4)
                {
                    WolfSkin.Ammount -= 4;
                    WolfAmor.Ammount ++;
                }
                break;
        }
    }
}