using System.Numerics;
using System.Runtime.CompilerServices;

namespace Program.CharacterClasses;

public class Magician : ICharacter 
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
        this.libro = new Book();
        this.TotalHealth = Health;
        this.ListInventory =  listInventory;
    }
    public int Armor
    {
        get
        {
            int totalArmor = 0;
            foreach (Items item in this.Inventory.ListInventory)
            {
                totalArmor += item.Armor;
            }

            return totalArmor;
        }
    }
    public void Attack(ICharacter target, Spell hechizo)
    {
            int aditionalDamage = 0;
            foreach(Items item in this.ListInventory)
            {
                aditionalDamage += item.MagicDamage;
            }
        target.get(Health) -= (MagicDamage + hechizo.Damage + aditionalDamage) - target.Armor;
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