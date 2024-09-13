namespace Program;

public class items
{
    private string name;
    public double damage;
    public double healing;

    public items(string name, double damage, double healing)
    {
        this.name = name;
        this.damage = damage;
        this.healing = healing;
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
        this.healing = newHealing;
    }
}