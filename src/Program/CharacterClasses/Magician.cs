using System.Numerics;
using System.Runtime.CompilerServices;

namespace Program.CharacterClasses;

public class Magician : ICharacter 
{
    public Inventory Inventory { get; set; }
    public List<Inventory> ListInventory { get; set; }
    public string Name{ get; set; }
    public int Health { get; set; }
    public int MagicDamage { get; set; }
    public int TotalHealth{ get; set; }
    
    public Spells Hechizo_actual{ get; set; }
    
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
            foreach (IItems item in this.Inventory.ListInventory)
            {
                totalArmor += item.Armor;
            }

            return totalArmor;
        }
    }
    public void Attack(ICharacter target)
    {
        bool hechizo_en_libro = false;
        foreach (Spells item in this.libro.SpellList)
        {
            if (item == Hechizo_actual) {hechizo_en_libro = true;}
        }
        if (hechizo_en_libro){
            int aditionalDamage = 0;
            foreach(IItems item in this.Inventory.ListInventory)
            {
                aditionalDamage += item.MagicDamage;
            }
            target.Health -= (MagicDamage + Hechizo_actual.Damage + aditionalDamage) - target.Armor;}
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

    public void PickObject(IItems item)
    {
        this.Inventory.PickObject(item);
    }

    public void DropObject(IItems item)
    {
        this.Inventory.DropObject(item);
    }
}