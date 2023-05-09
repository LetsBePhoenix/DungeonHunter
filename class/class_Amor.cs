class Amor
{
    // Eigenschaften
    public string Name { get; set; }
    public string ID { get; set; }
    public int Ammount { get; set; }
    public int Secure { get; set; }
    // Konstruktor
    public Amor(string Name, string ID, int Ammount, int Secure)
    {
        this.Name = Name;
        this.ID = ID;
        this.Ammount = Ammount;
        this.Secure = Secure;
    }
    // Funktionen
}