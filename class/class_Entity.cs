class Entity
{
    // Eigenschaften
    public string Name { get; set; }
    public string ID { get; set; }
    public int DMG { get; set; }
    public int HP { get; set; }
    // Konstruktor
    public Entity(string Name, string ID, int DMG, int HP)
    {
        this.Name = Name;
        this.ID = ID;
        this.DMG = DMG;
        this.HP = HP;
    }
    // Funktionen
    public void Attack(Player Player)
    {
        Player.TakeDmg(this.DMG);
    }
}

class Wolf : Entity
{
    public Wolf(string Name, string ID, int DMG, int HP) : base(Name, ID, DMG, HP)
    {

    }
}