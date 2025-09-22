namespace Program.CharacterClasses;

public class Elfo: ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int MagicDamage { get; set; }
    public int MeleeDamage { get; set; }
    public int TotalHealth { get; set; }

    private Inventory listInventory;

    
    public Elfo(string name, int health, int magicDamage, int meleeDamage, Inventory listInventory)
    {
        this.Name = name;
        this.Health = health;
        this.MagicDamage = magicDamage;
        this.MeleeDamage = meleeDamage;
        this.TotalHealth = health;
        this.listInventory = listInventory;
    }
    
    public void Attack(ICharacter target)
    {
        int aditionalDamage = 0;
        foreach(Items item in this.listInventory)
        {
            aditionalDamage += item.Damage + item.MagicDamage;
        }
        target.Health =- MeleeDamage + aditionalDamage;
    }

    public void Heal()
    {
        this.Health = TotalHealth ;
    }

    public void CheckInventory()
    {
        this.listInventory.CheckInventory();
    }

    public void PickObject()
    {
        this.listInventory.PickObject();
    }

    public void DropObject()
    {
        this.listInventory.DropObject();
    }
}