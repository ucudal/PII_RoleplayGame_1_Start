using Program;

namespace Ucu.Poo.RoleplayGame;

public class Sword : IItems
{
    public string Name { get; set; }
    public int MagicDamage { get; set; }
    public int Damage { get; set; }
    public int Armor { get; set; }

    public string Type
    {
        get { return this.Type = "Arma";}
        set{}
    }
    

    public Sword(string name, int magicDamage, int damage)
    {
        this.Name = name;
        this.MagicDamage = magicDamage;
        this.Damage = damage;
       
    }
}
