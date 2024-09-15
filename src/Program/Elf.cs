

public class Elf

{
    private string name;
    private double health;
    private double maxHealth;
    private List<Item> items;

    public Elf(string name, double health, double strength)
    {
        this.name = name;
        this.health = health;
        this.maxHealth = health;
        this.items = new List<Item>();
        
    }

    public void HelpOther(IChar compañero)
    {
        if (compañero.GetHealth() < compañero.GetMaxHealth())
        {
            /*switch ()
            {
                
            }*/
        }

    }
}