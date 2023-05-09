class Player
{
    // Eigenschaften
    string Name { get; set; }
    int HP { get; set; }
    int MaxHP { get; set; }
    int LVL { get; set; }
    int Exp { get; set; }
    // Konstruktor
    public Player(string Name, int HP, int MaxHP, int LVL, int Exp)
    {
        this.Name = Name;
        this.HP = HP;
        this.MaxHP = MaxHP;
        this.LVL = LVL;
        this.Exp = Exp;
    }
    // Funktionen
    public void TakeDmg(int ammount)
    {
        this.HP -= ammount;
    }
    public void Attack(Weapon weapon, Entity opponent)
    {
        if (opponent.HP - weapon.Dmg > 0) 
        {
            opponent.HP -= weapon.Dmg;
        }
        else
        {
            opponent.HP = 0;
        }
    }
}