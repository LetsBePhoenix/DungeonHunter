class Player
{
    // Eigenschaften
    string Name { get; set; }
    int HP { get; set; }
    int MaxHP { get; set; }
    int LVL { get; set; }
    int Exp { get; set; }
    int Money { get; set; }
    // Konstruktor
    public Player(string Name, int HP, int MaxHP, int LVL, int Exp, int Money)
    {
        this.Name = Name;
        this.HP = HP;
        this.MaxHP = MaxHP;
        this.LVL = LVL;
        this.Exp = Exp;
        this.Money = Money;
    }
    // Funktionen
    public void TakeDmg(int ammount)
    {
        this.HP -= ammount;
    }
    public void Cure(int ammount)
    {
        if(this.HP + ammount < this.MaxHP)
        {
            this.HP += ammount;
        }
        else
        {
            this.HP = this.MaxHP;
        }
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
    public void Use_Potion(Item ChosenPotion)
    {
        switch (ChosenPotion)
        {
            case Item HealPotion:
                Cure(20);
                break;
        }
    }
    public void Shop_Item(Item ChosenItem, int Ammount)
    {
        switch (ChosenItem)
        {
            case Item HealPotion:
                if (HealPotion.Price * Ammount <= 0)
                {
                    for (int i = 0; i <= Ammount; i++)
                    {
                        HealPotion.Ammount++;
                    }
                }
                break;
        }
    }
}