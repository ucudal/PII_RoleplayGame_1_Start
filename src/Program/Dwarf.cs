
public class Dwarf : Character
{
    public Dwarf(string name, double maxHealth, double baseDamage, List<Item> items)
        : base(name, maxHealth, baseDamage, items, CharacterType.Dwarf)
    { }
    
    // Método para aplicar una habilidad que aumenta el daño
    public void GoCrazy()
    {
        damage += damage / 2;
    }
}

