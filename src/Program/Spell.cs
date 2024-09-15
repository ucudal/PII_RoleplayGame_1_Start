public class Spell
{
    // Atributos del Hechizo
    private string name;      // Nombre del hechizo
    private int damage;        // Poder del hechizo (impacto en el ataque)
    private int manaCost;     // Costo de mana para lanzar el hechizo

    // Constructor
    public Spell(string name, int power, int manaCost)
    {
        this.name = name;
        this.damage = power;
        this.manaCost = manaCost;
    }
    
    public void Cast(Character objetivo)
    {
        // El hechizo ataca y reduce la vida del objetivo
        objetivo.Health -= damage;

        // Asegurar que la vida no sea negativa
        if (objetivo.GetHealth() < 0)
        {
            objetivo.Health = 0;
        }
    }

    // Obtener el nombre del hechizo
    public string GetName()
    {
        return name;
    }
    
    // Obtener el poder del hechizo
    public int GetDamage()
    {
        return damage;
    }

    // Obtener el costo de mana del hechizo
    public int GetManaCost()
    {
        return manaCost;
    }

    // Método para mostrar la información del hechizo
    public override string ToString()
    {
        return $"Hechizo: {name}, Poder: {damage}, Costo de mana: {manaCost}";
    }
}