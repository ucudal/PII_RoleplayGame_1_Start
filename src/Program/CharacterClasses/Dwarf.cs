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

    public int Armor
    {
        get
        {
            int totalArmor = 0;
            foreach (Items item in this.ListInventory)
            {
                totalArmor += item.Armor;
            }

            return totalArmor;
        }
    }

    public Inventory ListInventory {get; set;}
    
    public Dwarf(string name, int health, int meleeDamage, Inventory listInventory)
    {
        this.Name = name;
        this.Health = health;
        this.MeleeDamage = meleeDamage;
        this.TotalHealth = health;
        this.ListInventory = listInventory;
        
       
    }

    public void Attack(ICharacter target)
    {
        int additionalDamage = 0;
        foreach(Items item in this.ListInventory)
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
 