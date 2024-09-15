
public class Character: IChar
{
    private string name;
    private double health;
    private double maxHealth;
    protected double damage;
    private List<Item> items;
    public CharacterType characterType { get; protected set; }
    
    public enum CharacterType
    {
        Elf,
        Dwarf,
        Wizard
    }

        public Character(string name, double maxHealth, double damage, List<Item> items, Character.CharacterType characterType)
    {
        this.name = name;
        this.health = maxHealth;
        this.maxHealth = maxHealth;
        this.damage = damage;
        this.items = items;
        this.characterType = characterType;
    }
    
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
    
    public double GetMaxHealth()
    {
        return maxHealth;
    }
    
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
    public virtual double GetTotalAttackValue()
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
        Health += maxHealth / 3; // Vida inicial / 3
    }
}