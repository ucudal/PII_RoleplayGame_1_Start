namespace Program;

public class Items //Creo clase Items
{
    //Atributos:
    public string Name { get; set; }
    public int MagicDamage { get; set; }
    public int Damage { get; set; }
    public int Armor { get; set; }
    public string Type { get; set; }

    //Constructor:
    public Items(string name, int magicDamage, int damage, int armor, string type)
    {
        this.Name = name;
        this.MagicDamage = magicDamage;
        this.Damage = damage;
        this.Armor = armor;
        this.Type = type;
    }
}