using System.IO.Pipes;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace Program.CharacterClasses;

public class Dwarf : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int MeleeDamage { get; set; }
    public int TotalHealth {get; set;}
    public Inventory Inventory {get; set;}
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
    
    public Dwarf(string name, int health, int meleeDamage, Inventory listInventory)
    {
        this.Name = name;
        this.Health = health;
        this.MeleeDamage = meleeDamage;
        this.TotalHealth = health;
        this.Inventory = listInventory;
        
       
    }

    public void Attack(ICharacter target)
    {
        int additionalDamage = 0;
        foreach(Items item in this.Inventory.ListInventory)
        {
            additionalDamage += item.Damage;
        }
        target.Health -= ((MeleeDamage + additionalDamage) - target.Armor);
    }
    

    public void Heal()
    {
        this.Health = TotalHealth;
    }

    public void CheckInventory()
    {       
        this.Inventory.CheckInventory();
    }

    public void PickObject(Items item)
    {
        this.Inventory.PickObject(item);
    }

    public void DropObject(Items item)
    {
        this.Inventory.DropObject(item);
    }

   
}
 