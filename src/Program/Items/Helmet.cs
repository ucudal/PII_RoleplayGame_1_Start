using Program;

namespace Ucu.Poo.RoleplayGame;

public class Helmet : IItems
{
    public string Name { get; set; }
    public int MagicDamage { get; set; }
    public int Damage { get; set; }
    public int Armor { get; set; }
    public string Type
    {
        get { return this.Type = "Casco";}
        set{}
    }
    public Helmet(string name, int magicDamage, int damage, int armor)
    {
        this.Name = name;
        this.MagicDamage = magicDamage;
        this.Damage = damage;
        this.Armor = armor;
    }
}
