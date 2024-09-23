
/*La clase base Character define atributos y comportamientos comunes
(como el nombre, la vida y los items), pero los personajes individuales 
implementan comportamientos más específicos según su naturaleza.*/

using Program2;

public class Character: IChar
{
    private string name;
    private double health;
    private double maxHealth;
    protected double damage;
    private List<Iitem> items;
    public CharacterType characterType { get; protected set; }
    
    //enumerado con los tipos de personajes
    public enum CharacterType
    {
        Elf,
        Dwarf,
        Wizard
    }

    public Character(string name, double maxHealth, double damage, List<Iitem> items, Character.CharacterType characterType)
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
            //si el valor que le quieren asignar a la vida es mayor a su cantidad de vida máxima entonces asignamos la vida al máximo
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

    public void AddItem(Iitem item)
    {
        items.Add(item);
    }
    
    public void RemoveItem(Iitem item)
    {
        items.Remove(item);
    }


    //opbtenemos el valor total de ataque
    public double GetTotalAttackValue()
    {
        double attackValue = damage;
        foreach (var item in items)
        {
            attackValue += item.GetDamage();
        }
        return attackValue;
    }

//obtener el valor total de defensa
    public double GetTotalDefenseValue()
    {
        double defenseValue = 0;
        foreach (var item in items)
        {
            defenseValue += item.GetDefense(); 
        }
        return defenseValue;
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