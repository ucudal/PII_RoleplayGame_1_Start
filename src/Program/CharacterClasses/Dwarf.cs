using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace Program.CharacterClasses;

public class Dwarf : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int MeleeDamage { get; set; }
    public int TotalHealth {get; set;}

    private Inventory ListInventory;
    
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
        target.Health =- MeleeDamage;
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
 