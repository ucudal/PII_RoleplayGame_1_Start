using System.Collections;
public class Wizard
{
    private string name;
    private double damage;
    private double health;
    private double maxHealth;
    private double mana;
    private double maxMana;
    private List<Spell> listaLibroDeHechizos;
    private List<Item> items;
    
    public double Health
    {
        get { return health; }
        set {
            if (value > maxHealth)
            {
                health = maxHealth;
            }
            else
            {
                health = value;
            }
        }
    }

    public Wizard(string name, bool magic, List<Item> listaDeItems, List<Spell> listaDeHechizos)
    {
        this.name = name;
        this.damage = damage;
        this.items = listaDeItems;
        this.listaLibroDeHechizos = listaDeHechizos;
    }
    
    // Agregar hechizo al libro de hechizos
    public List<Spell> learnMagic(Spell hechizo)
    {
        listaLibroDeHechizos.Add(hechizo);
        return listaLibroDeHechizos;
    }
}