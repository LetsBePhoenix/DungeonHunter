class Item
{
    // Eigenschaften
    public string Name { get; set; }
    public string ID { get; set; }
    public int Ammount { get; set; }
    public int Price { get; set; }
    // Konstruktor
    public Item(string Name, string ID, int Ammount, int price)
    {
        this.Name = Name;
        this.ID = ID;
        this.Ammount = Ammount;
        Price = price;
    }
}