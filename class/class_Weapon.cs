class Weapon
{
    // Eigenschaften
    public string Name { get; set; }
    public string ID { get; set; }
    public string Type { get; set; }
    public int Dmg { get; set; }
    // Konstruktor
    public Weapon(string Name, string ID, string Type, int Dmg)
    {
        this.Name = Name;
        this.ID = ID;
        this.Type = Type;
        this.Dmg = Dmg;
    }
    // Fungtionen
    public void Use(Entity opponent)
    {
        
    }
}