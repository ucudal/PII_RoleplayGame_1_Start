using System.Collections;
public class Wizard
{
    private string name;
    private double damage;
    private double health;
    private double maxHealth;
    private double mana;
    private double maxMana;
    private List<Hechizo> listaLibroDeHechizos;
    private List<Item> items;
    
    public double Health
    {
        get { return health; }
        set { health = value; }
    }

    public double Mana
    {
        get { return mana; }
        set { mana = value; }
    }
    public Wizard(string name, bool magic, List<Item> listaDeItems, List<Hechizo> listaDeHechizos)
    {
        this.name = name;
        this.damage = damage;
        this.items = listaDeItems;
        this.listaLibroDeHechizos = listaDeHechizos;
    }
    
    // Agregar hechizo al libro de hechizos
    public List<Hechizo> learnMagic(Hechizo hechizo)
    {
        listaLibroDeHechizos.Add(hechizo);
        return listaLibroDeHechizos;
    }

    public double GetMana() => mana;
    
    public void LanzarHechizo(Hechizo hechizo, Character objetivo)
    {
        if (Mana >= hechizo.GetManaCost())
        {
            Mana -= hechizo.GetManaCost();
            hechizo.Lanzar( Character objetivo);
            Console.WriteLine($"{name} ha lanzado {hechizo.GetName()} contra {Character.GetName}, consumiendo {hechizo.GetManaCost()} de mana.");
        }
        else
        {
            Console.WriteLine($"{name} no tiene suficiente mana para lanzar {hechizo.GetName()}.");
        }
    }
    
    //---------Interfaz--------------------------------//
    
    // Obtener el nombre del personaje
    public string GetName() => name;
    
    // Obtener la vida actual del personaje
    public double GetHealth() => health;
    
    // Añadir un ítem al personaje
    public void AddItem(Item item)
    {
        items.Add(item);
    }

    // Eliminar un ítem del personaje
    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    // Obtener el valor total de ataque
    public double GetTotalAttackValue()
    {
        double attackValue = 0;
        foreach (var item in items)
        {
            attackValue += item.damage;
        }
        
        return attackValue; // La fuerza suma al valor de ataque
    }

    // Obtener el valor total de defensa
    public double GetTotalDefenseValue()
    {
        double defenseValue = 0;
        foreach (var item in items)
        {
            defenseValue += item.defense;
        }
        
        return defenseValue; // La fuerza suma al valor de ataque
    }

    // Método para recibir daño
    public void ReceiveDamage(double damage)
    {
        if (Health - damage < 0)
        {
            Health = 0;
        }
        else
        {
            health -= damage;
        }
    }

    // Método para curar al personaje
    public void Heal()
    {
        Health = this.maxHealth; // Vida inicial
    }
    
    public void RestoreMana()
    {
        Mana += this.maxMana / 3; // Recupera 1/3 de su mana máximo
    }
}