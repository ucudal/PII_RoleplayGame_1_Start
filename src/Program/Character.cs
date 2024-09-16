
/*La clase base Character define atributos y comportamientos comunes
(como el nombre, la vida y los items), pero los personajes individuales 
implementan comportamientos más específicos según su naturaleza.*/
public class Character: IChar
{
    private string name;
    private double health;
    private double maxHealth;
    protected double damage;
    private List<Item> items;
    public CharacterType characterType { get; protected set; }
    
    // Enumerado con los tipos de personajes
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
            // Si el valor que le quieren asignar a la vida es mayor a su cantidad de vida máxima entonces asignamos la vida al máximo
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
    
    // Obtener la vida maxima que puede tener el personaje
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
        
        return damage + attackValue; // La fuerza suma al valor de ataque
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
    public virtual void Heal()
    {
        Health += maxHealth / 3; // Vida inicial / 3
    }
    
    // Metodo para atacar a otro personaje
    public void Attack(Character enemy)
    {
        enemy.ReceiveDamage(this.damage);
    }
}