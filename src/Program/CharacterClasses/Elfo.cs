namespace Program.CharacterClasses;

public class Elfo: ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int MagicDamage { get; set; }
    public int MeleeDamage { get; set; }
    public int TotalHealth { get; set; }
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

    public Inventory Inventory {get; set;}

    
    public Elfo(string name, int health, int magicDamage, int meleeDamage, Inventory listInventory)
    {
        this.Name = name;
        this.Health = health;
        this.MagicDamage = magicDamage;
        this.MeleeDamage = meleeDamage;
        this.TotalHealth = health;
        this.Inventory = listInventory;
    }
    
    public void Attack(ICharacter target)
    {
        int additionalDamage = 0;
        foreach(Items item in this.Inventory.ListInventory)
        {
            additionalDamage += item.Damage + item.MagicDamage;
        }
        target.Health -= ((MeleeDamage + additionalDamage) - target.Armor);
    }

    public void Heal()
    {
        this.Health = TotalHealth ;
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