/*La clase Spell representa un hechizo que puede ser lanzado por personajes mágicos como wizard.
 Cada hechizo tiene un costo de maná y un poder, afectando a los enemigos o ayudando a aliados en el combate.*/
public class Spell
{
    private string name;      
    private int damage;       
    private int manaCost;     // Costo de mana para lanzar el hechizo
    public Spell(string name, int power, int manaCost)
    {
        this.name = name;
        this.damage = power;
        this.manaCost = manaCost;
    }
    
    // Recitar hechizo
    public void Recite(Character objetivo)
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
    
    // Obtener el daño del hechizo
    public int GetDamage()
    {
        return damage;
    }

    // Obtener el costo de mana del hechizo
    public int GetManaCost()
    {
        return manaCost;
    }
}