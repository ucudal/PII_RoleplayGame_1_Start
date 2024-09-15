public class Hechizo
{
    // Atributos del Hechizo
    private string name;      // Nombre del hechizo
    private int damage;        // Poder del hechizo (impacto en el ataque)
    private int manaCost;     // Costo de mana para lanzar el hechizo
    
    // Constructor
    public Hechizo(string name, int power, int manaCost)
    {
        this.name = name;
        this.damage = power;
        this.manaCost = manaCost;
    }
    
    public void Lanzar(Char objetivo)
    {
        // El hechizo ataca y reduce la vida del objetivo
        objetivo.Health -= damage;

        // Asegurar que la vida no sea negativa
        if (objetivo.GetHealth < 0)
        {
            objetivo.GetHealth = 0;
        }

        Console.WriteLine($"{objetivo.GetName} ha recibido {damage} puntos de daño por el hechizo {name}.");
    }

    // Obtener el nombre del hechizo
    public string GetName()
    {
        return name;
    }

    // Obtener el poder del hechizo
    public int GetPower()
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