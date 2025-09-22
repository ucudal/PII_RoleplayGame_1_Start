using System.Numerics;
using System.Runtime.CompilerServices;

namespace Program.CharacterClasses;

public class Magician : ICharacter 
{
    private Inventory Inventory;
    
    public string Name{ get; set; }
    public int Health { get; set; }
    public int MagicDamage { get; set; }
    public int TotalHealth{ get; set; }
    
    SpellBook libro { get; set; }

    public Magician(string name, int health, int magicDamage, Inventory listInventory)
    {
        this.Name = name;
        this.Health = health;
        this.MagicDamage = magicDamage;
        this.libro = new SpellBook();
        this.TotalHealth = Health;
        this.Inventory =  listInventory;
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
    public void Attack(ICharacter target, Spells hechizo)
    {
        bool hechizo_en_libro = false;
        foreach (Spells item in libro)
        {
            if (item == hechizo) {hechizo_en_libro = true;}
        }
        if (hechizo_en_libro){
            int aditionalDamage = 0;
            foreach(Items item in this.Inventory.ListInventory)
            {
                aditionalDamage += item.MagicDamage;
            }
            target.Health -= (MagicDamage + hechizo.Damage + aditionalDamage) - target.Armor;}
        else {Console.WriteLine("No tiene ese hechizo");}
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