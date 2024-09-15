public class Item
{
    private string name;
    public double damage;
    public double defense;

    public Item(string name, double damage, double healing)
    {
        this.name = name;
        this.damage = damage;
        this.defense = healing;
    }

    public double GetDamage()
    {
        return damage;
    }

    public void NewDamage (double newDamage) // modificar 
    {
        this.damage = newDamage;
    }

    public void NewHealing (double newHealing)
    {
        this.defense = newHealing;
    }
}