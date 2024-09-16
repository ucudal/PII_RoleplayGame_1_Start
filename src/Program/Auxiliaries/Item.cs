/*La clase Item representa objetos que los personajes pueden equipar, como armas o armaduras,
 y que influyen en sus atributos de ataque y defensa. Los items son clave para mejorar las 
 habilidades en combate y se pueden equipar, cambiar o quitar.*/
public class Item
{
    private string name;
    public double damage;
    public double defense;

    public Item(string name, double damage, double defense)
    {
        this.name = name;
        this.damage = damage;
        this.defense = defense;
    }

    public string GetName()
    {
        return name;
    }
    // Consultar el daño que hace el Item
    public double GetDamage()
    {
        return damage;
    }
    
    // Consultar la defensa que tiene el Item
    public double GetDefense()
    {
        return defense;
    }
}