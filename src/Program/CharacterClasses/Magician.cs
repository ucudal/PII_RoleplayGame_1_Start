using System.Numerics;
using System.Runtime.CompilerServices;

namespace Program.CharacterClasses;

public class Magician
{
    private Inventory ListInventory;
    public string name{ get; set; }
    public int Health { get; set; }
    public int MagicDamage { get; set; }
    public int TotalHealth{ get; set; }
    
    Book libro { get; set; }

    public Magician(string name, int health, int magicDamage, Inventory listInventory)
    {
        this.name = name;
        this.Health = health;
        this.MagicDamage = magicDamage;
        Book libro = new Book();
        this.TotalHealth = Health;
        this.ListInventory =  listInventory;
    }
    
    public void Attack(ICharacter target, Spell hechizo)
    {
        target.get(Health) = target.get(Health) - (MagicDamage + Spell.Damage));
    }
    
    public void Heal()
    {
        this.Health = TotalHealth;
    }
    
    public void CheckInventory()
    {
        this.ListInventory.CheckInventory();
    }

    public void PickObject()
    {
        this.ListInventory.PickObject();
    }

    public void DropObject()
    {
        this.ListInventory.DropObject();
    }
}