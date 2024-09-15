public class Item
{
    private string name;
    public double damage;
    public double defense;

    public Item(string name, double damage, double defense)
    {
        this.name = name;
        this.damage = damage;
        this.defense = defense;
    }

    // Consultar el daño que hace el Item
    public double GetDamage()
    {
        return damage;
    }
    
    // Consultar la defensa que tiene el Item
    public double GetDefense()
    {
        return defense;
    }
}